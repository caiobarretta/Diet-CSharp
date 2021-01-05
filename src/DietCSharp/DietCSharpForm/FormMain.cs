using Core.Entities.Enums;
using Services;
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
using Core.Entities.DietcSharp;
using Core.Interfaces;
using Infrastructure;

namespace DietCSharpForm
{
    public partial class FormMain : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DietCScharpContext _ctx;
        private readonly UsuarioService _usuarioService;
        private bool isLogin { get; set; }
        private int CodigoUsuario { get; set; }
        private readonly TipoUsuario _tipoUsuario;
        private readonly ToolStripHelper _toolStripHelper;
        public FormMain()
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            isLogin = formLogin.isLogin;
            if (isLogin)
            {
                CodigoUsuario = formLogin.CodigoUsuario;
                _usuarioService = new UsuarioService(_unitOfWork);
                _tipoUsuario = _usuarioService.GetTipoUsuarioById(CodigoUsuario);
            }
            _toolStripHelper = new ToolStripHelper(_tipoUsuario);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!isLogin)
                this.Close();

            if (_tipoUsuario == TipoUsuario.Paciente)
            {
                toolStripRefeicoesCadastrar.Visible = false;
                toolStripPorcAlimentosCadastrar.Visible = false;
                toolStripDietaCadastrar.Visible = false;
                toolStripPacienteCadastrar.Visible = false;
            }

            if (_tipoUsuario == TipoUsuario.Nutricionista)
            {
                toolStripRefeicoesCadastrar.Click += _toolStripHelper.ToolStripRefeicoesCadastrar_Click;
                toolStripPorcAlimentosCadastrar.Click += _toolStripHelper.ToolStripPorcAlimentosCadastrar_Click;
                toolStripDietaCadastrar.Click += _toolStripHelper.ToolStripDietaCadastrar_Click;
                toolStripPacienteCadastrar.Click += _toolStripHelper.ToolStripPacienteCadastrar_Click;
            }
            toolStripRefeicoesPesquisar.Click += _toolStripHelper.ToolStripRefeicoesPesquisar_Click;
            toolStripPorcAlimentosPesquisar.Click += _toolStripHelper.ToolStripPorcAlimentosPesquisar_Click;
            toolStripDietaPesquisar.Click += _toolStripHelper.ToolStripDietaPesquisar_Click;
            toolStripPacientePesquisar.Click += _toolStripHelper.ToolStripPacientePesquisar_Click;
        }
    }
}
