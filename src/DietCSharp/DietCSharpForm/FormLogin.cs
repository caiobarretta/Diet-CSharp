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
        public FormLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
            isLogin = false;
        }

        private void txtBPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEditarSalvar_Click(object sender, EventArgs e)
        {
            var ehUsuario = _usuarioService.IsLogin(txtBEmail.Text, txtBPassword.Text, out int CodigoUsuario);
            if (!ehUsuario)
            {
                MessageBox.Show("Usuário ou senha invalido!");
                return;
            }
            isLogin = ehUsuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
