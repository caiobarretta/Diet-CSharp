
using Core.Entities.DietcSharp;
using DietCSharpForm.Base;
using System.Windows.Forms;

namespace DietCSharpForm
{
    partial class FormEditarCadastrarDieta : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chbPorcAlimento = new System.Windows.Forms.CheckedListBox();
            this.lvlPorAlimento = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarCancelar
            // 
            this.btnCadastrarCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCadastrarCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarCancelar.Location = new System.Drawing.Point(452, 396);
            this.btnCadastrarCancelar.Name = "btnCadastrarCancelar";
            this.btnCadastrarCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarCancelar.TabIndex = 19;
            this.btnCadastrarCancelar.Text = "Cancelar";
            this.btnCadastrarCancelar.UseVisualStyleBackColor = false;
            this.btnCadastrarCancelar.Click += new System.EventHandler(this.btnCadastrarCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(364, 396);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chbPorcAlimento
            // 
            this.chbPorcAlimento.FormattingEnabled = true;
            this.chbPorcAlimento.Location = new System.Drawing.Point(12, 177);
            this.chbPorcAlimento.Name = "chbPorcAlimento";
            this.chbPorcAlimento.Size = new System.Drawing.Size(522, 94);
            this.chbPorcAlimento.TabIndex = 17;
            // 
            // lvlPorAlimento
            // 
            this.lvlPorAlimento.AutoSize = true;
            this.lvlPorAlimento.Location = new System.Drawing.Point(12, 159);
            this.lvlPorAlimento.Name = "lvlPorAlimento";
            this.lvlPorAlimento.Size = new System.Drawing.Size(108, 15);
            this.lvlPorAlimento.TabIndex = 16;
            this.lvlPorAlimento.Text = "Poção de Alimento";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 304);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(522, 86);
            this.txtDescricao.TabIndex = 15;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 286);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 118);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(522, 23);
            this.txtNome.TabIndex = 21;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 48);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(522, 23);
            this.txtCodigo.TabIndex = 23;
            // 
            // FormEditarCadastrarDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrarCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chbPorcAlimento);
            this.Controls.Add(this.lvlPorAlimento);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Name = "FormEditarCadastrarDieta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditarDieta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditarCadastrarDieta_FormClosed);
            this.Load += new System.EventHandler(this.FormEditarCadastrarDieta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckedListBox chbPorcAlimento;
        private System.Windows.Forms.Label lvlPorAlimento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private TextBox txtDescricao;
    }
}