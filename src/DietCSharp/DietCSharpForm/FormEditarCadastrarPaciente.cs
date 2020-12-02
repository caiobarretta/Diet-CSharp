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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarPaciente : Form, IFormBase<Usuario>
    {
        public IService<Usuario> _service { get; private set; }

        public CriarEditarService<Usuario> criarEditarService { get; private set; }

        public TipoDeOperacao TipoDeOperacao { get; private set; }

        public int Id { get; set; }

        public FormEditarCadastrarPaciente()
        {
            InitializeComponent();
        }

        public IFormBase<Usuario> BuildServices(TipoDeOperacao tipoDeOperacao)
        {
            this._service = new UsuarioService();
            TipoDeOperacao = tipoDeOperacao;
            criarEditarService = new CriarEditarService<Usuario>(this._service, tipoDeOperacao);
            return this;
        }

        public Form GetForm() => this;

        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarPaciente_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();
            var dietaService = new DietaService();
            var dietaList = dietaService.Get(int.MaxValue, 0);
            dietaList.ForEach(r =>
            {
                lstDieta.Items.Add(string.Format("{0}-{1}", r.ID, r.Nome));
            });

            Usuario usuario = null;
            bool entidadeCarregada = criarEditarService.LoadEntity(ref usuario, Id);
            if (entidadeCarregada)
            {
                txtNome.Text = usuario.Nome;
                txtDescricao.Text = usuario.Descricao;

                if (usuario.ID_Dieta.HasValue)
                {
                    var dieta = dietaService.Get(usuario.ID_Dieta.Value);
                    var formatoConteudoItemLst = string.Format("{0}-{1}", dieta.ID, dieta.Nome);
                    ComponentesFormHelper.SetItemSelectListBox(lstDieta, formatoConteudoItemLst);
                }
            }
        }

        private void btnCadastrarSalvar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
                throw new ArgumentException("Valor do código inválido.");

            Usuario usuario = null;
            if (TipoDeOperacao == TipoDeOperacao.Criar)
                usuario = new Usuario();
            else if (TipoDeOperacao == TipoDeOperacao.Editar)
                criarEditarService.LoadEntity(ref usuario, Id);
            else
                throw new NotImplementedException("Fluxo não implementado!");

            usuario.Nome = txtNome.Text;
            usuario.Descricao = txtDescricao.Text;
            usuario.Usuario1 = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            usuario.ID_Perfil = new PerfilService().Search("Paciente").Where(x => x.Nome == "Paciente").FirstOrDefault().ID;
            usuario.ID_Dieta = ComponentesFormHelper.GetIdSelectedFromListBox(lstDieta);

            criarEditarService.Executar(usuario, out string mensagem);

            MessageBox.Show(mensagem);
        }
    }
}
