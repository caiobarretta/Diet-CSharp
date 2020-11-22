using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class EditarDieta : Form
    {
        public EditarDieta()
        {
            InitializeComponent();
        }

        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
