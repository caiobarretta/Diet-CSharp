using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using DietCSharpForm.Base;
using DietCSharpForm.Helpers;
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
        private readonly IService<TEntity> _service;
        private readonly IFormBase<TEntity> _formBase;
        private string lastSearch { get; set; }
        public PesquisarForm(IService<TEntity> service, IFormBase<TEntity> formBase)
        {
            this._formBase = formBase;
            this._service = service;
            InitializeComponent();
        }

        private void Pesquisar_Load(object sender, EventArgs e) => dtgPesquisa.DataSource = _service.Get(Take, Skip);

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var list = _service.Search(txtPesquisar.Text);
            if (list.Count <= 0)
                MessageBox.Show($"A pesquisa: {txtPesquisar.Text} não retornou resultado!");
            dtgPesquisa.DataSource = list;
            lastSearch = txtPesquisar.Text;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var dataGridEstaValido = ValidaComponentesFormHelper.ValidaERetornaIdDataGrid(dtgPesquisa, out string mensagem, out int id);
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
            var dataGridEstaValido = ValidaComponentesFormHelper.ValidaERetornaIdDataGrid(dtgPesquisa, out string mensagem, out int id);
            if (!dataGridEstaValido)
            {
                MessageBox.Show(mensagem);
                return;
            }
            var entidade = this._service.Get(id);
            this._service.Delete(entidade);
            var list = _service.Search(lastSearch);
            dtgPesquisa.DataSource = list;
        }
    }
}
