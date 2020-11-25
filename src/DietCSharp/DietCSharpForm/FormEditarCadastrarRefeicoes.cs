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
    public partial class FormEditarCadastrarRefeicoes : Form
    {
        private TipoDeOperacao TipoDeOperacao { get; set; }
        private int Id { get; set; }
        public FormEditarCadastrarRefeicoes()
        {
            TipoDeOperacao = TipoDeOperacao.Criar;
            InitializeComponent();
        }

        public FormEditarCadastrarRefeicoes(int id)
        {
            Id = id;
            TipoDeOperacao = TipoDeOperacao.Editar;
            InitializeComponent();
        }

        private void btnEditarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarRefeicoes_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();
        }
    }
}
