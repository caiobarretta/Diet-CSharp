using Core.Entities.DietcSharp;
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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            List<PorcaoDeAlimento> porcAli = new List<PorcaoDeAlimento>();
            using (var ctx = new DietCScharpContext())
            {
                // implementar no botão pesquisar
               // porcAli = ctx.PorcaoDeAlimentos.Where(x => x.Nome.Contains("Caio")).ToList();
                porcAli = ctx.PorcaoDeAlimentos.ToList();
            }
            dtgPesquisa.DataSource = porcAli;
        }
    }
}
