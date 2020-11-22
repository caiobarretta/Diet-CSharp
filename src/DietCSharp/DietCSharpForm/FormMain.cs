using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStripRefeicoesCadastrar.Click += ToolStripRefeicoesCadastrar_Click;
            toolStripRefeicoesPesquisar.Click += ToolStripRefeicoesPesquisar_Click;
            toolStripPorcAlimentosCadastrar.Click += ToolStripPorcAlimentosCadastrar_Click;
            toolStripPorcAlimentosPesquisar.Click += ToolStripPorcAlimentosPesquisar_Click;
            toolStripDietaCadastrar.Click += ToolStripDietaCadastrar_Click;
            toolStripDietaPesquisar.Click += ToolStripDietaPesquisar_Click;
            toolStripPacienteCadastrar.Click += ToolStripPacienteCadastrar_Click;
            toolStripPacientePesquisar.Click += ToolStripPacientePesquisar_Click;
        }

        private void ToolStripPacientePesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisa = new Pesquisar();
            pesquisa.Show();
        }

        private void ToolStripPacienteCadastrar_Click(object sender, EventArgs e)
        {
            AdiconarPaciente paciente = new AdiconarPaciente();
            paciente.Show();
        }

        private void ToolStripDietaPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisa = new Pesquisar();
            pesquisa.Show();
        }

        private void ToolStripDietaCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarDieta cadDieta = new CadastrarDieta();
            cadDieta.Show();
        }

        private void ToolStripPorcAlimentosPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisa = new Pesquisar();
            pesquisa.Show();
        }

        private void ToolStripPorcAlimentosCadastrar_Click(object sender, EventArgs e)
        {
            CadastroPorcAlimento cadPorcAli = new CadastroPorcAlimento();
            cadPorcAli.Show();
        }

        private void ToolStripRefeicoesPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar pesquisarRef = new Pesquisar();
            pesquisarRef.Show();
        }

        private void ToolStripRefeicoesCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastroRef = new Cadastro();
            cadastroRef.Show();
         
        }


        
    }
}
