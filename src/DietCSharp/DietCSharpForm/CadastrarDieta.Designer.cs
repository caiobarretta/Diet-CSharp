
namespace DietCSharpForm
{
    partial class CadastrarDieta
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
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.lvlPorAlimento = new System.Windows.Forms.Label();
            this.checkLBoxPorcAlimento = new System.Windows.Forms.CheckedListBox();
            this.btnCadastrarCancelar = new System.Windows.Forms.Button();
            this.btnCadastrarSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 268);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(12, 286);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(522, 86);
            this.txtBoxDescricao.TabIndex = 3;
            // 
            // lvlPorAlimento
            // 
            this.lvlPorAlimento.AutoSize = true;
            this.lvlPorAlimento.Location = new System.Drawing.Point(12, 115);
            this.lvlPorAlimento.Name = "lvlPorAlimento";
            this.lvlPorAlimento.Size = new System.Drawing.Size(108, 15);
            this.lvlPorAlimento.TabIndex = 4;
            this.lvlPorAlimento.Text = "Poção de Alimento";
            // 
            // checkLBoxPorcAlimento
            // 
            this.checkLBoxPorcAlimento.FormattingEnabled = true;
            this.checkLBoxPorcAlimento.Location = new System.Drawing.Point(12, 133);
            this.checkLBoxPorcAlimento.Name = "checkLBoxPorcAlimento";
            this.checkLBoxPorcAlimento.Size = new System.Drawing.Size(522, 94);
            this.checkLBoxPorcAlimento.TabIndex = 5;
            // 
            // btnCadastrarCancelar
            // 
            this.btnCadastrarCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCadastrarCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarCancelar.Location = new System.Drawing.Point(452, 378);
            this.btnCadastrarCancelar.Name = "btnCadastrarCancelar";
            this.btnCadastrarCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarCancelar.TabIndex = 13;
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
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(364, 378);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarSalvar.TabIndex = 12;
            this.btnCadastrarSalvar.Text = "Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            // 
            // CadastrarDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnCadastrarCancelar);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.Controls.Add(this.checkLBoxPorcAlimento);
            this.Controls.Add(this.lvlPorAlimento);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastrarDieta";
            this.Text = "CadastrarDieta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Label lvlPorAlimento;
        private System.Windows.Forms.CheckedListBox checkLBoxPorcAlimento;
        private System.Windows.Forms.Button btnCadastrarCancelar;
        private System.Windows.Forms.Button btnCadastrarSalvar;
    }
}