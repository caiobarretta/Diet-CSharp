﻿using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Services;
using DietCSharpForm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core.Interfaces;
using Infrastructure;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarRefeicoes : Form, IFormBase<Refeicao>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DietCScharpContext _ctx;
        public IService<Refeicao> _service { get; private set; }

        public CriarEditarService<Refeicao> criarEditarService { get; private set; }

        public TipoDeOperacao TipoDeOperacao { get; private set; }

        public int Id { get; set; }

        public FormEditarCadastrarRefeicoes()
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);
            InitializeComponent();
        }

        public IFormBase<Refeicao> BuildServices(TipoDeOperacao tipoDeOperacao)
        {
            this._service = new RefeicoesService(_unitOfWork);
            TipoDeOperacao = tipoDeOperacao;
            criarEditarService = new CriarEditarService<Refeicao>(this._service, tipoDeOperacao);
            return this;
        }

        public Form GetForm() => this;

        private void btnEditarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarRefeicoes_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();

            Refeicao refeicao = null;
            bool entidadeCarregada = criarEditarService.LoadEntity(ref refeicao, Id);
            if (entidadeCarregada)
            {
                txtNome.Text = refeicao.Nome;
                txtDescricao.Text = refeicao.Descricao;
            }
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                    throw new ArgumentException("Valor do código inválido.");

                Refeicao refeicao = null;
                if (TipoDeOperacao == TipoDeOperacao.Criar)
                    refeicao = new Refeicao();
                else if (TipoDeOperacao == TipoDeOperacao.Editar)
                    criarEditarService.LoadEntity(ref refeicao, Id);
                else
                    throw new NotImplementedException("Fluxo não implementado!");

                refeicao.Nome = txtNome.Text;
                refeicao.Descricao = txtDescricao.Text;

                if (!criarEditarService.Executar(refeicao, out string mensagem))
                {
                    MessageBox.Show(mensagem);
                    return;
                }

                MessageBox.Show(mensagem);
                _unitOfWork.Commit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
