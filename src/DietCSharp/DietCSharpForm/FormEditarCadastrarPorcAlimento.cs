using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Core.Services;
using DietCSharpForm.Base;
using DietCSharpForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarPorcAlimento : Form, IFormBase<PorcaoDeAlimento>
    {
        public IService<PorcaoDeAlimento> _service { get; private set; }

        public CriarEditarService<PorcaoDeAlimento> criarEditarService { get; private set; }

        public TipoDeOperacao TipoDeOperacao { get; private set; }

        public int Id { get; set; }

        public FormEditarCadastrarPorcAlimento()
        {
            InitializeComponent();
        }

        public IFormBase<PorcaoDeAlimento> BuildServices(TipoDeOperacao tipoDeOperacao)
        {
            this._service = new PorcaoDeAlimentoService();
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

            var refeicaoService = new RefeicoesService();
            var refeicoesList = refeicaoService.Get(int.MaxValue, 0);

            refeicoesList.ForEach(r =>
            {
                chbRefeicoes.Items.Add(string.Format("{0}-{1}",r.ID_Refeicao,r.Nome));
            });

            PorcaoDeAlimento porcaoDeAlimento = null;
            bool entidadeCarregada = criarEditarService.LoadEntity(ref porcaoDeAlimento, Id);
            if (entidadeCarregada)
            {
                txtNome.Text = porcaoDeAlimento.Nome;
                txtDescricao.Text = porcaoDeAlimento.Descricao;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
            porcaoDeAlimento.Descricao = txtNome.Text;

            List<int> listIdRefeicoes = ValidaComponentesFormHelper.GetIdCheckedListBoxCheckedItems(chbRefeicoes);

            criarEditarService.Executar(porcaoDeAlimento, out string mensagem);
            new PorcaoDeAlimentoService().AssociarPorcaoRefeicoes(listIdRefeicoes, porcaoDeAlimento.ID_PorcAlimento);
            
            MessageBox.Show(mensagem);
        }

        
    }
}
