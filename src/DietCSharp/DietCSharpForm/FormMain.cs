using Core.Entities.Enums;
using Services;
using DietCSharpForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Entities.DietcSharp;
using Core.Interfaces;
using Infrastructure;
using Core.Interfaces.Service.Base;

namespace DietCSharpForm
{
    public partial class FormMain : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DietCScharpContext _ctx;
        private readonly UsuarioService _usuarioService;
        private readonly DietaService _dietaService;
        private readonly PorcaoDeAlimentoService _porcaoDeAlimentoService;
        private readonly DiaDaSemanaService _diaDaSemanaService;
        private readonly RefeicoesService _refeicoesService;
        private readonly RegistroDeAtividadeService _registroService;
        public CriarEditarService<RegistroDeAtividade> criarEditarService { get; private set; }
        private bool isLogin { get; set; }
        private int CodigoUsuario { get; set; }
        private readonly TipoUsuario _tipoUsuario;
        private readonly ToolStripHelper _toolStripHelper;
        public FormMain()
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            isLogin = formLogin.isLogin;
            if (isLogin)
            {
                CodigoUsuario = formLogin.CodigoUsuario;
                _usuarioService = new UsuarioService(_unitOfWork);
                _dietaService = new DietaService(this._unitOfWork);
                _porcaoDeAlimentoService = new PorcaoDeAlimentoService(_unitOfWork);
                _diaDaSemanaService = new DiaDaSemanaService(_unitOfWork);
                _refeicoesService = new RefeicoesService(_unitOfWork);
                _tipoUsuario = _usuarioService.GetTipoUsuarioById(CodigoUsuario);
                _registroService = new RegistroDeAtividadeService(_unitOfWork);
            }
            _toolStripHelper = new ToolStripHelper(_tipoUsuario);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                this.Close();
                return;
            }

            if (_tipoUsuario == TipoUsuario.Paciente)
            {
                toolStripRefeicoesCadastrar.Visible = false;
                toolStripPorcAlimentosCadastrar.Visible = false;
                toolStripDietaCadastrar.Visible = false;
                toolStripPacienteCadastrar.Visible = false;
            }

            if (_tipoUsuario == TipoUsuario.Nutricionista)
            {
                toolStripRefeicoesCadastrar.Click += _toolStripHelper.ToolStripRefeicoesCadastrar_Click;
                toolStripPorcAlimentosCadastrar.Click += _toolStripHelper.ToolStripPorcAlimentosCadastrar_Click;
                toolStripDietaCadastrar.Click += _toolStripHelper.ToolStripDietaCadastrar_Click;
                toolStripPacienteCadastrar.Click += _toolStripHelper.ToolStripPacienteCadastrar_Click;
            }
            toolStripRefeicoesPesquisar.Click += _toolStripHelper.ToolStripRefeicoesPesquisar_Click;
            toolStripPorcAlimentosPesquisar.Click += _toolStripHelper.ToolStripPorcAlimentosPesquisar_Click;
            toolStripDietaPesquisar.Click += _toolStripHelper.ToolStripDietaPesquisar_Click;
            toolStripPacientePesquisar.Click += _toolStripHelper.ToolStripPacientePesquisar_Click;



            var usuario = _usuarioService.Get(CodigoUsuario);

            lblNomeUsuario.Text = usuario.Nome;
            lblNomePerfil.Text = _tipoUsuario.ToString();

            if (usuario.ID_Dieta.HasValue)
            {
                CarregaDietaFormulario(usuario);

                if (!RegistroValidoNoBancoPelaDataSelecionadaNoCalendario(out RegistroDeAtividade registro))
                {
                    MessageBox.Show("Não existe registros salvos para o dia: " + monthCalendar.SelectionStart.ToString());
                    return;
                }

                this.LoadFormRegistroDeAtividade(monthCalendar.SelectionStart, registro);
            }
            else
            {
                lblDieta.Text = "Paciente não possui dieta cadastrada";
                gbDieta.Enabled = false;
                gbRegistrodeAtividades.Enabled = false;
            }
        }

        private void CarregaDietaFormulario(Usuario usuario)
        {
            var dieta = _dietaService.Get(usuario.ID_Dieta.Value);
            lblDieta.Text = dieta.Nome;
            var porcoesDeAlimento = _porcaoDeAlimentoService.RetornaPorcaoDeAlimentoPeloIdDaDieta(usuario.ID_Dieta.Value);

            porcoesDeAlimento.ForEach(porc =>
            {
                TreeNode treeNode = treeViewPorcaoDeAlimento.Nodes.Add(porc.Nome);
                clbPorcaoDeAlimentosConsumido.Items.Add(string.Format("{0}-{1}", porc.ID, porc.Nome));

                var diasDaSemana = _diaDaSemanaService.RetornarDiaDaSemanaPeloIdDaPorcaoDeAlimento(porc.ID);
                diasDaSemana.ForEach(dia => { treeNode.Nodes.Add(dia.Nome); });

                var refeicoes = _refeicoesService.RetornaRefeicoesPeloIdDaProcaoDeAlimento(porc.ID);
                refeicoes.ForEach(@ref => { treeNode.Nodes.Add(@ref.Nome); });

            });

            treeViewPorcaoDeAlimento.ExpandAll();
        }

        private void LoadFormRegistroDeAtividade(DateTime dataSelecionada, RegistroDeAtividade registro)
        {
            monthCalendar.SelectionStart = dataSelecionada;

            var PorcoesDeAlimento = _registroService.RetornaProcaoDeAlimentoPeloRegistroDeAtividade(registro.ID);

            foreach (var porcao in PorcoesDeAlimento)
            {
                var formatoConteudoItemChb = string.Format("{0}-{1}", porcao.ID, porcao.Nome);
                ComponentesFormHelper.SetItemCheckState(clbPorcaoDeAlimentosConsumido, formatoConteudoItemChb, CheckState.Checked);
            }
            txtComentario.Text = registro.Descricao;
            ConfiguraSentimentosRadioButton(registro);

        }

        private void ConfiguraSentimentosRadioButton(RegistroDeAtividade registro)
        {
            if ("PASSEI FOME".Equals(registro.Sentimento.Trim().ToUpper()))
                rbPasseiFome.Checked = true;
            else if ("SATISFEITO".Equals(registro.Sentimento.Trim().ToUpper()))
                rbSatisfeito.Checked = true;
            else if ("BUCHO CHEIO".Equals(registro.Sentimento.Trim().ToUpper()))
                rbBuchoCheio.Checked = true;
        }

        private bool RegistroValidoNoBancoPelaDataSelecionadaNoCalendario(out RegistroDeAtividade registro)
        {
            registro = _registroService.Search(new RegistroDeAtividade(), monthCalendar.SelectionStart.ToString()).FirstOrDefault();
            if (registro == null)
                return false;
            return true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSelecionada = monthCalendar.SelectionStart;
                
                if (!RegistroValidoNoBancoPelaDataSelecionadaNoCalendario(out RegistroDeAtividade registro))
                {
                    criarEditarService = new CriarEditarService<RegistroDeAtividade>(this._registroService, TipoDeOperacao.Criar);
                    registro = new RegistroDeAtividade();
                }
                else
                {
                    criarEditarService = new CriarEditarService<RegistroDeAtividade>(this._registroService, TipoDeOperacao.Editar);
                    criarEditarService.LoadEntity(ref registro, registro.ID);
                }

                registro.Descricao = txtComentario.Text;
                registro.Nome = dataSelecionada.ToString();
                registro.Registro = dataSelecionada;
                registro.Sentimento = RetornaSentimentoSelecionado();
                
                List<int> listIdPorcoesDeAlimentos = ComponentesFormHelper.GetIdCheckedListBoxCheckedItems(clbPorcaoDeAlimentosConsumido);

                if (!criarEditarService.Executar(registro, out string mensagem))
                {
                    MessageBox.Show(mensagem);
                    return;
                }
                _unitOfWork.Commit();
                _registroService.AssociarPorcaoRegistroDeAlimentos(listIdPorcoesDeAlimentos, registro.ID);
                
                MessageBox.Show(mensagem);
                _unitOfWork.Commit();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar dados do formulário:" + ex.Message);
            }


        }

        private string RetornaSentimentoSelecionado()
        {
            if (rbPasseiFome.Checked == true)
                return "PASSEI FOME";
            else if (rbSatisfeito.Checked == true)
                return "SATISFEITO";
            else if (rbBuchoCheio.Checked == true)
                return "BUCHO CHEIO";

            throw new ArgumentException("Selecione um sentimento válido.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormMain_Load(sender, e);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!RegistroValidoNoBancoPelaDataSelecionadaNoCalendario(out RegistroDeAtividade registro))
            {
                MessageBox.Show("Não existe registros salvos para o dia: " + monthCalendar.SelectionStart.ToString());
                ClearForm();
                return;
            }

            this.LoadFormRegistroDeAtividade(monthCalendar.SelectionStart, registro);
        }

        private void ClearForm()
        {
            txtComentario.Text = string.Empty;
            rbPasseiFome.Checked = false;
            rbSatisfeito.Checked = false;
            rbBuchoCheio.Checked = false;
        }
    }
}
