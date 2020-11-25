using Core.Entities.Enums;
using Core.Services;
using DietCSharpForm.Helpers;
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
        private readonly UsuarioService _usuarioService;
        private bool isLogin { get; set; }
        private int CodigoUsuario { get; set; }
        private TipoUsuario TipoUsuario { get; set; }
        private readonly ToolStripHelper _toolStripHelper;
        public FormMain()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            isLogin = formLogin.isLogin;
            if (isLogin)
            {
                CodigoUsuario = formLogin.CodigoUsuario;
                _usuarioService = new UsuarioService();
                TipoUsuario = _usuarioService.GetTipoUsuarioById(CodigoUsuario);
            }
            _toolStripHelper = new ToolStripHelper();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!isLogin)
                this.Close();
            
            toolStripRefeicoesCadastrar.Click += _toolStripHelper.ToolStripRefeicoesCadastrar_Click;
            toolStripRefeicoesPesquisar.Click += _toolStripHelper.ToolStripRefeicoesPesquisar_Click;
            toolStripPorcAlimentosCadastrar.Click += _toolStripHelper.ToolStripPorcAlimentosCadastrar_Click;
            toolStripPorcAlimentosPesquisar.Click += _toolStripHelper.ToolStripPorcAlimentosPesquisar_Click;
            toolStripDietaCadastrar.Click += _toolStripHelper.ToolStripDietaCadastrar_Click;
            toolStripDietaPesquisar.Click += _toolStripHelper.ToolStripDietaPesquisar_Click;
            toolStripPacienteCadastrar.Click += _toolStripHelper.ToolStripPacienteCadastrar_Click;
            toolStripPacientePesquisar.Click += _toolStripHelper.ToolStripPacientePesquisar_Click;
        }
    }
}
