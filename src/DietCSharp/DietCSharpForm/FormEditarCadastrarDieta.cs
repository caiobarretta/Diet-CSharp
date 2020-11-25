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
    public partial class FormEditarCadastrarDieta : Form
    {


        private FormEditarCadastrarDieta()
        {
            InitializeComponent();
        }
        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarDieta_Load(object sender, EventArgs e)
        {
            //this.Text = TipoDeOperacao.ToString();
            //this.txtCodigo.Text = Id.ToString();
        }
    }
}
