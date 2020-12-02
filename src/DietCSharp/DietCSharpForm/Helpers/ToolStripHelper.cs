using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service;
using Core.Interfaces.Service.Base;
using Core.Services;
using DietCSharpForm.Base;
using DietCSharpForm.Services.Componente;
using DietCSharpForm.Services.Componente.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietCSharpForm.Helpers
{
    public class ToolStripHelper
    {
        private readonly TipoUsuario _tipoUsuario;

        private readonly IDietaService _dietaService;
        private readonly IUsuarioService _usuarioService;
        private readonly IPorcaoDeAlimentoService _porcaoDeAlimentoService;
        private readonly IRefeicoesService _refeicoesService;

        public ToolStripHelper(TipoUsuario TipoUsuario)
        {
            _tipoUsuario = TipoUsuario;
            _dietaService = new DietaService();
            _usuarioService = new UsuarioService();
            _porcaoDeAlimentoService = new PorcaoDeAlimentoService();
            _refeicoesService = new RefeicoesService();
        }

        #region Paciente
        public void ToolStripPacientePesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditarCadastrarPaciente().BuildServices(TipoDeOperacao.Editar);
                var componenteService = new UsuarioComponenteService();
                new PesquisarForm<Usuario>(_usuarioService, form, componenteService, _tipoUsuario).ShowDialog();
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
                new PesquisarForm<Dietum>(_dietaService, form, componenteService, _tipoUsuario).ShowDialog();
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
                new PesquisarForm<PorcaoDeAlimento>(_porcaoDeAlimentoService, form, componenteService, _tipoUsuario).ShowDialog();
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
                new PesquisarForm<Refeico>(_refeicoesService, form, componenteService, _tipoUsuario).ShowDialog();
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
