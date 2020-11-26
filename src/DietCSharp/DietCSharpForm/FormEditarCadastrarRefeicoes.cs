using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Core.Services;
using DietCSharpForm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarRefeicoes : Form, IFormBase<Refeico>
    {
        public IService<Refeico> _service { get; private set; }

        public CriarEditarService<Refeico> criarEditarService { get; private set; }

        public TipoDeOperacao TipoDeOperacao { get; private set; }

        public int Id { get; set; }

        public FormEditarCadastrarRefeicoes()
        {
            InitializeComponent();
        }

        public IFormBase<Refeico> BuildServices(TipoDeOperacao tipoDeOperacao)
        {
            this._service = new RefeicoesService();
            TipoDeOperacao = tipoDeOperacao;
            criarEditarService = new CriarEditarService<Refeico>(this._service, tipoDeOperacao);
            return this;
        }

        public Form GetForm() => this;

        private void btnEditarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarRefeicoes_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();

            Refeico refeicao = null;
            bool entidadeCarregada = criarEditarService.LoadEntity(ref refeicao, Id);
            if (entidadeCarregada)
            {
                txtNome.Text = refeicao.Nome;
                txtDescricao.Text = refeicao.Descricao;
            }
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
                throw new ArgumentException("Valor do código inválido.");

            Refeico refeicao = null;
            if (TipoDeOperacao == TipoDeOperacao.Criar)
                refeicao = new Refeico();
            else if(TipoDeOperacao == TipoDeOperacao.Editar)
                criarEditarService.LoadEntity(ref refeicao, Id);
            else
                throw new NotImplementedException("Fluxo não implementado!");

            refeicao.Nome = txtNome.Text;
            refeicao.Descricao = txtDescricao.Text;
            criarEditarService.Executar(refeicao, out string mensagem);

            MessageBox.Show(mensagem);
        }
    }
}
