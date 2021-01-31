using Core.Entities.DietcSharp;
using Core.Interfaces;
using Core.Interfaces.Service;
using Infrastructure;
using Services;
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
        private readonly IUnitOfWork _unitOfWork;
        private readonly DietCScharpContext _ctx;
        private readonly IUsuarioService _usuarioService;
        public bool isLogin { get; set; }
        public int CodigoUsuario { get; set; }
        public FormLogin()
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);
            _usuarioService = new UsuarioService(_unitOfWork);
            InitializeComponent();
            isLogin = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            /*
            txtUsuario.Text = "nutri";
            txtSenha.Text = "1234";
            btnLogin_Click(sender, e);
            */
        }
    }
}
