using Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class FormLogin : Form
    {
        private readonly UsuarioService _usuarioService;
        public bool isLogin { get; set; }
        public int CodigoUsuario { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            isLogin = false;
        }

        private void btnEditarSalvar_Click(object sender, EventArgs e)
        {
            var ehUsuario = _usuarioService.IsUsuario(txtUsuario.Text, txtSenha.Text, out int codigoUsuario);
            if (!ehUsuario)
            {
                MessageBox.Show("Usuário ou senha invalido!");
                return;
            }
            isLogin = ehUsuario;
            CodigoUsuario = codigoUsuario;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
