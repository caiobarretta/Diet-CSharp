
using System.Windows.Forms;

namespace DietCSharpForm
{
    partial class FormEditarCadastrarPorcAlimento : Form
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
            this.lblRefeicoes = new System.Windows.Forms.Label();
            this.chbRefeicoes = new System.Windows.Forms.CheckedListBox();
            this.chbDiasSemana = new System.Windows.Forms.CheckedListBox();
            this.btnCadastrarCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRefeicoes
            // 
            this.lblRefeicoes.AutoSize = true;
            this.lblRefeicoes.Location = new System.Drawing.Point(13, 180);
            this.lblRefeicoes.Name = "lblRefeicoes";
            this.lblRefeicoes.Size = new System.Drawing.Size(57, 15);
            this.lblRefeicoes.TabIndex = 23;
            this.lblRefeicoes.Text = "Refeições";
            // 
            // chbRefeicoes
            // 
            this.chbRefeicoes.FormattingEnabled = true;
            this.chbRefeicoes.Location = new System.Drawing.Point(12, 198);
            this.chbRefeicoes.Name = "chbRefeicoes";
            this.chbRefeicoes.Size = new System.Drawing.Size(522, 58);
            this.chbRefeicoes.TabIndex = 22;
            // 
            // chbDiasSemana
            // 
            this.chbDiasSemana.FormattingEnabled = true;
            this.chbDiasSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sabado"});
            this.chbDiasSemana.Location = new System.Drawing.Point(12, 119);
            this.chbDiasSemana.Name = "chbDiasSemana";
            this.chbDiasSemana.Size = new System.Drawing.Size(522, 58);
            this.chbDiasSemana.TabIndex = 21;
            // 
            // btnCadastrarCancelar
            // 
            this.btnCadastrarCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCadastrarCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarCancelar.Location = new System.Drawing.Point(452, 404);
            this.btnCadastrarCancelar.Name = "btnCadastrarCancelar";
            this.btnCadastrarCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarCancelar.TabIndex = 20;
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
            this.btnSalvar.Location = new System.Drawing.Point(364, 404);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 277);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(522, 120);
            this.txtDescricao.TabIndex = 18;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 259);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dias da Semana";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(522, 23);
            this.txtNome.TabIndex = 25;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(13, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(521, 23);
            this.txtCodigo.TabIndex = 28;
            // 
            // FormEditarCadastrarPorcAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblRefeicoes);
            this.Controls.Add(this.chbRefeicoes);
            this.Controls.Add(this.chbDiasSemana);
            this.Controls.Add(this.btnCadastrarCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Name = "FormEditarCadastrarPorcAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditarPorcAlimento";
            this.Load += new System.EventHandler(this.FormEditarCadastrarPorcAlimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRefeicoes;
        private System.Windows.Forms.CheckedListBox chbRefeicoes;
        private System.Windows.Forms.CheckedListBox chbDiasSemana;
        private System.Windows.Forms.Button btnCadastrarCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}