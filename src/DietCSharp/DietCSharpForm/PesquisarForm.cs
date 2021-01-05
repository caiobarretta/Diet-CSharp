using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces;
using Core.Interfaces.Service.Base;
using DietCSharpForm.Base;
using DietCSharpForm.Helpers;
using DietCSharpForm.Interfaces.Componente.Base;
using DietCSharpForm.Services.Componente;
using DietCSharpForm.Services.Componente.Base;
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
    public partial class PesquisarForm<TEntity> : Form  where TEntity : Entity
    {
        private const int Take = 10;
        private const int Skip = 0;
        private readonly TEntity _entity;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IService<TEntity> _service;
        private readonly IFormBase<TEntity> _formBase;
        private readonly IDefaultService<TEntity> _defaultComponenteService;
        private readonly TipoUsuario _tipoUsuario;
        private string lastSearch { get; set; }
        public PesquisarForm(IUnitOfWork unitOfWork, IService<TEntity> service, IFormBase<TEntity> formBase, IDefaultService<TEntity> defaultComponenteService, TipoUsuario tipoUsuario, TEntity entity)
        {
            _entity = entity;
            _unitOfWork = unitOfWork;
            _tipoUsuario = tipoUsuario;
            _formBase = formBase;
            _service = service;
            _defaultComponenteService = defaultComponenteService;
            InitializeComponent();
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            var list = _service.Get(Take, Skip);
            this._defaultComponenteService.ConfigureGridSearch(dtgPesquisa, list);

            if (_tipoUsuario == TipoUsuario.Paciente)
            {
                btnEditar.Visible = false;
                btnExcluir.Visible = false;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var list = _service.Search(_entity, txtPesquisar.Text);
            if (list.Count <= 0)
                MessageBox.Show($"A pesquisa: {txtPesquisar.Text} não retornou resultado!");

            this._defaultComponenteService.ConfigureGridSearch(dtgPesquisa, list);
            lastSearch = txtPesquisar.Text;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var dataGridEstaValido = ComponentesFormHelper.ValidaERetornaIdDataGrid(dtgPesquisa, out string mensagem, out int id);
            if (!dataGridEstaValido)
            {
                MessageBox.Show(mensagem);
                return;
            }

            _formBase.Id = id;
            _formBase.GetForm().ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var dataGridEstaValido = ComponentesFormHelper.ValidaERetornaIdDataGrid(dtgPesquisa, out string mensagem, out int id);
            if (!dataGridEstaValido)
            {
                MessageBox.Show(mensagem);
                return;
            }
            var entidade = this._service.Get(id);
            this._service.Delete(entidade);
            _unitOfWork.Commit();
            var list = _service.Search(_entity, lastSearch);
            dtgPesquisa.DataSource = list;
        }
    }
}
