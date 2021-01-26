using Core.Entities.DietcSharp;
using Core.Entities.Enums;
using Core.Interfaces.Service.Base;
using Services;
using DietCSharpForm.Base;
using DietCSharpForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Infrastructure;
using Core.Interfaces;

namespace DietCSharpForm
{
    public partial class FormEditarCadastrarDieta : Form, IFormBase<Dietum>
    {
        private readonly DietCScharpContext _ctx;

        public IService<Dietum> _service { get; private set; }
        public CriarEditarService<Dietum> criarEditarService { get; private set; }
        public TipoDeOperacao TipoDeOperacao { get; private set; }
        public int Id { get; set; }
        private readonly IUnitOfWork _unitOfWork;
        public FormEditarCadastrarDieta()
        {
            _ctx = new DietCScharpContext();
            _unitOfWork = new UnitOfWork(_ctx);
            InitializeComponent();
        }

        public IFormBase<Dietum> BuildServices(TipoDeOperacao tipoDeOperacao)
        {
            this._service = new DietaService(_unitOfWork);
            TipoDeOperacao = tipoDeOperacao;
            criarEditarService = new CriarEditarService<Dietum>(this._service, tipoDeOperacao);
            return this;
        }

        public Form GetForm() => this;

        private void btnCadastrarCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarCadastrarDieta_Load(object sender, EventArgs e)
        {
            this.Text = TipoDeOperacao.ToString();
            this.txtCodigo.Text = Id.ToString();
            var porcaoDeAlimentoService = new PorcaoDeAlimentoService(_unitOfWork);
            var porcaoList = porcaoDeAlimentoService.Get(int.MaxValue, 0);
            porcaoList.ForEach(r =>
            {
                chbPorcAlimento.Items.Add(string.Format("{0}-{1}", r.ID, r.Nome));
            });

            Dietum dietum = null;
            bool entidadeCarregada = criarEditarService.LoadEntity(ref dietum, Id);
            if (entidadeCarregada)
            {
                txtNome.Text = dietum.Nome;
                txtDescricao.Text = dietum.Descricao;

                foreach (var item in dietum.PorcaoDeAlimentoDieta)
                {
                    var porcaoDeAlimento = porcaoDeAlimentoService.Get(item.ID_Dieta);
                    var formatoConteudoItemChb = string.Format("{0}-{1}", porcaoDeAlimento.ID, porcaoDeAlimento.Nome);
                    ComponentesFormHelper.SetItemCheckState(chbPorcAlimento, formatoConteudoItemChb, CheckState.Checked);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                    throw new ArgumentException("Valor do código inválido.");

                Dietum dietum = null;
                if (TipoDeOperacao == TipoDeOperacao.Criar)
                    dietum = new Dietum();
                else if (TipoDeOperacao == TipoDeOperacao.Editar)
                    criarEditarService.LoadEntity(ref dietum, Id);
                else
                    throw new NotImplementedException("Fluxo não implementado!");

                dietum.Nome = txtNome.Text;
                dietum.Descricao = txtDescricao.Text;

                List<int> listIdProcaoAlimento = ComponentesFormHelper.GetIdCheckedListBoxCheckedItems(chbPorcAlimento);

                if (!criarEditarService.Executar(dietum, out string mensagem))
                {
                    MessageBox.Show(mensagem);
                    return;
                }
                _unitOfWork.Commit();

                var porcaoDeAlimentoService = new PorcaoDeAlimentoService(_unitOfWork);
                porcaoDeAlimentoService.AssociarPorcaoAlimentoDieta(listIdProcaoAlimento, dietum.ID);

                _unitOfWork.Commit();
                MessageBox.Show(mensagem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FormEditarCadastrarDieta_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
