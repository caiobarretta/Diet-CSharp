using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Core.Services;
using DietCSharpForm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarPaciente : Form
    {
        public IService<Dietum> _service { get; private set; }
        public CriarEditarService<Dietum> criarEditarService { get; private set; }
        public TipoDeOperacao TipoDeOperacao { get; private set; }
        public int Id { get; set; }

        public FormEditarCadastrarPaciente(TipoDeOperacao tipoDeOperacao)
        {
            InitializeComponent();
        }

        public Form BuildServices(IService<Dietum> service, TipoDeOperacao tipoDeOperacao)
        {
            _service = service;
            criarEditarService = new CriarEditarService<Dietum>(_service, tipoDeOperacao);
            TipoDeOperacao = tipoDeOperacao;
            return this;
        }

        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarPaciente_Load(object sender, EventArgs e)
        {
            //this.Text = TipoDeOperacao.ToString();
            //this.txtCodigo.Text = Id.ToString();
        }
    }
}
