using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service;
using Core.Interfaces.Service.Base;
using Services;
using DietCSharpForm.Base;
using DietCSharpForm.Services.Componente;
using DietCSharpForm.Services.Componente.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Interfaces;
using Infrastructure;

namespace DietCSharpForm.Helpers
{
    public class ToolStripHelper
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DietCScharpContext _ctx;
        private readonly TipoUsuario _tipoUsuario;

        private readonly IDietaService _dietaService;
        private readonly IUsuarioService _usuarioService;
        private readonly IPorcaoDeAlimentoService _porcaoDeAlimentoService;
        private readonly IRefeicoesService _refeicoesService;

        public ToolStripHelper(TipoUsuario TipoUsuario)
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);

            _tipoUsuario = TipoUsuario;
            _dietaService = new DietaService(_unitOfWork);
            _usuarioService = new UsuarioService(_unitOfWork);
            _porcaoDeAlimentoService = new PorcaoDeAlimentoService(_unitOfWork);
            _refeicoesService = new RefeicoesService(_unitOfWork);
        }

        #region Paciente
        public void ToolStripPacientePesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditarCadastrarPaciente().BuildServices(TipoDeOperacao.Editar);
                var componenteService = new UsuarioComponenteService();
                var usuario = new Usuario();
                new PesquisarForm<Usuario>(_unitOfWork, _usuarioService, form, componenteService, _tipoUsuario, usuario).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToolStripPacienteCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                new FormEditarCadastrarPaciente().BuildServices(TipoDeOperacao.Criar).GetForm().ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Dieta
        public void ToolStripDietaPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditarCadastrarDieta().BuildServices(TipoDeOperacao.Editar);
                var componenteService = new DietaComponenteService();
                var dieta = new Dietum();
                new PesquisarForm<Dietum>(_unitOfWork, _dietaService, form, componenteService, _tipoUsuario, dieta).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToolStripDietaCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                new FormEditarCadastrarDieta().BuildServices(TipoDeOperacao.Criar).GetForm().ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region PorcaoAlimento
        public void ToolStripPorcAlimentosPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditarCadastrarPorcAlimento().BuildServices(TipoDeOperacao.Editar);
                var componenteService = new PorcaoDeAlimentoComponenteService();
                var porcaoDeAlimento = new PorcaoDeAlimento();
                new PesquisarForm<PorcaoDeAlimento>(_unitOfWork, _porcaoDeAlimentoService, form, componenteService, _tipoUsuario, porcaoDeAlimento).ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToolStripPorcAlimentosCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                new FormEditarCadastrarPorcAlimento().BuildServices(TipoDeOperacao.Criar).GetForm().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Refeições
        public void ToolStripRefeicoesPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditarCadastrarRefeicoes().BuildServices(TipoDeOperacao.Editar);
                var componenteService = new RefeicoesComponenteService();
                var refeicao = new Refeicao();
                new PesquisarForm<Refeicao>(_unitOfWork, _refeicoesService, form, componenteService, _tipoUsuario, refeicao).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ToolStripRefeicoesCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                new FormEditarCadastrarRefeicoes().BuildServices(TipoDeOperacao.Criar).GetForm().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
