using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Services;
using DietCSharpForm.Base;
using DietCSharpForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.Interfaces;
using Infrastructure;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarPorcAlimento : Form, IFormBase<PorcaoDeAlimento>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DietCScharpContext _ctx;
        public IService<PorcaoDeAlimento> _service { get; private set; }

        public CriarEditarService<PorcaoDeAlimento> criarEditarService { get; private set; }

        public TipoDeOperacao TipoDeOperacao { get; private set; }

        public int Id { get; set; }

        public FormEditarCadastrarPorcAlimento()
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);
            InitializeComponent();
        }

        public IFormBase<PorcaoDeAlimento> BuildServices(TipoDeOperacao tipoDeOperacao)
        {
            this._service = new PorcaoDeAlimentoService(_unitOfWork);
            TipoDeOperacao = tipoDeOperacao;
            criarEditarService = new CriarEditarService<PorcaoDeAlimento>(this._service, tipoDeOperacao);
            return this;
        }

        public Form GetForm() => this;

        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarPorcAlimento_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();

            var diadaSemanaService = new DiaDaSemanaService(_unitOfWork);
            var diadaSemanaList = diadaSemanaService.Get(int.MaxValue, 0);
            diadaSemanaList.ForEach(r =>
            {
                chbDiasSemana.Items.Add(string.Format("{0}-{1}", r.ID, r.Nome));
            });

            var refeicaoService = new RefeicoesService(_unitOfWork);
            var refeicoesList = refeicaoService.Get(int.MaxValue, 0);
            refeicoesList.ForEach(r =>
            {
                chbRefeicoes.Items.Add(string.Format("{0}-{1}", r.ID, r.Nome));
            });

            PorcaoDeAlimento porcaoDeAlimento = null;
            bool entidadeCarregada = criarEditarService.LoadEntity(ref porcaoDeAlimento, Id);
            if (entidadeCarregada)
            {
                txtNome.Text = porcaoDeAlimento.Nome;
                txtDescricao.Text = porcaoDeAlimento.Descricao;

                foreach (var item in porcaoDeAlimento.PorcaoDeAlimentoDiasdaSemanas)
                {
                    var diasdaSemana = diadaSemanaService.Get(item.ID_DiaSemana);
                    var formatoConteudoItemChb = string.Format("{0}-{1}", diasdaSemana.ID, diasdaSemana.Nome);
                    ComponentesFormHelper.SetItemCheckState(chbDiasSemana, formatoConteudoItemChb, CheckState.Checked);
                }

                foreach (var item in porcaoDeAlimento.RefeicaoPorcaoDeAlimentos)
                {
                    var refeicao = refeicaoService.Get(item.ID_Refeicao);
                    var formatoConteudoItemChb = string.Format("{0}-{1}", refeicao.ID, refeicao.Nome);
                    ComponentesFormHelper.SetItemCheckState(chbRefeicoes, formatoConteudoItemChb, CheckState.Checked);
                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                    throw new ArgumentException("Valor do código inválido.");

                PorcaoDeAlimento porcaoDeAlimento = null;
                if (TipoDeOperacao == TipoDeOperacao.Criar)
                    porcaoDeAlimento = new PorcaoDeAlimento();
                else if (TipoDeOperacao == TipoDeOperacao.Editar)
                    criarEditarService.LoadEntity(ref porcaoDeAlimento, Id);
                else
                    throw new NotImplementedException("Fluxo não implementado!");

                porcaoDeAlimento.Nome = txtNome.Text;
                porcaoDeAlimento.Descricao = txtDescricao.Text;

                List<int> listIdRefeicoes = ComponentesFormHelper.GetIdCheckedListBoxCheckedItems(chbRefeicoes);
                List<int> listIdDiasdaSemana = ComponentesFormHelper.GetIdCheckedListBoxCheckedItems(chbDiasSemana);

                if (!criarEditarService.Executar(porcaoDeAlimento, out string mensagem))
                {
                    MessageBox.Show(mensagem);
                    return;
                }
                _unitOfWork.Commit();

                var diasdaSemanaService = new DiaDaSemanaService(_unitOfWork);
                diasdaSemanaService.AssociarDiasDaSemanaRefeicoes(listIdDiasdaSemana, porcaoDeAlimento.ID);

                var porcaoDeAlimentoService = new PorcaoDeAlimentoService(_unitOfWork);
                porcaoDeAlimentoService.AssociarPorcaoRefeicoes(listIdRefeicoes, porcaoDeAlimento.ID);

                MessageBox.Show(mensagem);
                _unitOfWork.Commit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEditarCadastrarPorcAlimento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
