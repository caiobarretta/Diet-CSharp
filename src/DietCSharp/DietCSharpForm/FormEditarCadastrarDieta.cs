using Core.Entities.Enums;
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
        private TipoDeOperacao TipoDeOperacao { get; set; }
        private int Id { get; set; }
        public FormEditarCadastrarDieta()
        {
            TipoDeOperacao = TipoDeOperacao.Criar;
            InitializeComponent();
        }

        public FormEditarCadastrarDieta(int id)
        {
            Id = id;
            TipoDeOperacao = TipoDeOperacao.Editar;
            InitializeComponent();
        }

        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarDieta_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();
            
        }
    }
}
