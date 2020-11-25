using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service;
using Core.Interfaces.Service.Base;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietCSharpForm.Helpers
{
    public class ToolStripHelper
    {
        private readonly IDietaService _dietaService;
        private readonly IUsuarioService _usuarioService;
        private readonly IPorcaoDeAlimentoService _porcaoDeAlimentoService;
        private readonly IRefeicoesService _refeicoesService;

        public ToolStripHelper()
        {
            _dietaService = new DietaService();
            _usuarioService = new UsuarioService();
            _porcaoDeAlimentoService = new PorcaoDeAlimentoService();
            _refeicoesService = new RefeicoesService();
        }

        #region Paciente
        public void ToolStripPacientePesquisar_Click(object sender, EventArgs e) => new PesquisarForm<Usuario>(_usuarioService).ShowDialog();
        public void ToolStripPacienteCadastrar_Click(object sender, EventArgs e) => new FormEditarCadastrarPaciente().ShowDialog();
        #endregion

        #region Dieta
        public void ToolStripDietaPesquisar_Click(object sender, EventArgs e) => new PesquisarForm<Dietum>(_dietaService).ShowDialog();
        public void ToolStripDietaCadastrar_Click(object sender, EventArgs e) => new FormEditarCadastrarDieta().ShowDialog();
        #endregion
        #region PorcaoAlimento
        public void ToolStripPorcAlimentosPesquisar_Click(object sender, EventArgs e) => new PesquisarForm<PorcaoDeAlimento>(_porcaoDeAlimentoService).ShowDialog();
        public void ToolStripPorcAlimentosCadastrar_Click(object sender, EventArgs e) => new FormEditarCadastrarPorcAlimento().ShowDialog();
        #endregion

        #region Refeições
        public void ToolStripRefeicoesPesquisar_Click(object sender, EventArgs e) => new PesquisarForm<Refeico>(_refeicoesService).ShowDialog();
        public void ToolStripRefeicoesCadastrar_Click(object sender, EventArgs e) => new FormEditarCadastrarRefeicoes().ShowDialog();
        #endregion
    }
}
