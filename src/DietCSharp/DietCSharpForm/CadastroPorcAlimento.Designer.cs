
namespace DietCSharpForm
{
    partial class CadastroPorcAlimento
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
            this.btnCadastrarSalvar = new System.Windows.Forms.Button();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkLBoxDiasSemana = new System.Windows.Forms.CheckedListBox();
            this.checkLBoxREfeicoes = new System.Windows.Forms.CheckedListBox();
            this.lblRefeicoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarCancelar
            // 
            this.btnCadastrarCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCadastrarCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarCancelar.Location = new System.Drawing.Point(452, 407);
            this.btnCadastrarCancelar.Name = "btnCadastrarCancelar";
            this.btnCadastrarCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarCancelar.TabIndex = 11;
            this.btnCadastrarCancelar.Text = "Cancelar";
            this.btnCadastrarCancelar.UseVisualStyleBackColor = false;
            this.btnCadastrarCancelar.Click += new System.EventHandler(this.btnCadastrarCancelar_Click);
            // 
            // btnCadastrarSalvar
            // 
            this.btnCadastrarSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastrarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(364, 407);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarSalvar.TabIndex = 10;
            this.btnCadastrarSalvar.Text = "Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(12, 281);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(522, 120);
            this.txtBoxDescricao.TabIndex = 9;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 263);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(12, 35);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(522, 23);
            this.txtBoxNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dias da Semana";
            // 
            // checkLBoxDiasSemana
            // 
            this.checkLBoxDiasSemana.FormattingEnabled = true;
            this.checkLBoxDiasSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sabado"});
            this.checkLBoxDiasSemana.Location = new System.Drawing.Point(12, 98);
            this.checkLBoxDiasSemana.Name = "checkLBoxDiasSemana";
            this.checkLBoxDiasSemana.Size = new System.Drawing.Size(522, 58);
            this.checkLBoxDiasSemana.TabIndex = 13;
            // 
            // checkLBoxREfeicoes
            // 
            this.checkLBoxREfeicoes.FormattingEnabled = true;
            this.checkLBoxREfeicoes.Location = new System.Drawing.Point(12, 190);
            this.checkLBoxREfeicoes.Name = "checkLBoxREfeicoes";
            this.checkLBoxREfeicoes.Size = new System.Drawing.Size(522, 58);
            this.checkLBoxREfeicoes.TabIndex = 14;
            // 
            // lblRefeicoes
            // 
            this.lblRefeicoes.AutoSize = true;
            this.lblRefeicoes.Location = new System.Drawing.Point(14, 172);
            this.lblRefeicoes.Name = "lblRefeicoes";
            this.lblRefeicoes.Size = new System.Drawing.Size(57, 15);
            this.lblRefeicoes.TabIndex = 16;
            this.lblRefeicoes.Text = "Refeições";
            // 
            // CadastroPorcAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.lblRefeicoes);
            this.Controls.Add(this.checkLBoxREfeicoes);
            this.Controls.Add(this.checkLBoxDiasSemana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarCancelar);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroPorcAlimento";
            this.Text = "CadastroPorcAlimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCancelar;
        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkLBoxDiasSemana;
        private System.Windows.Forms.CheckedListBox checkLBoxREfeicoes;
        private System.Windows.Forms.Label lblRefeicoes;
    }
}