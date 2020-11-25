using Core.Entities.Base;
using Core.Entities.DietcSharp;
using Core.Interfaces.Service.Base;
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
        private const int Take = 1;
        private const int Skip = 10;
        private readonly IService<TEntity> _service;

        public PesquisarForm(IService<TEntity> service)
        {
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
        }
    }
}
