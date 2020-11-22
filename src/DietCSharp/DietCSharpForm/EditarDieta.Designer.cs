
namespace DietCSharpForm
{
    partial class EditarDieta
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
            this.checkLBoxPorcAlimento = new System.Windows.Forms.CheckedListBox();
            this.lvlPorAlimento = new System.Windows.Forms.Label();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            // btnCadastrarSalvar
            // 
            this.btnCadastrarSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastrarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(364, 396);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarSalvar.TabIndex = 18;
            this.btnCadastrarSalvar.Text = "Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            // 
            // checkLBoxPorcAlimento
            // 
            this.checkLBoxPorcAlimento.FormattingEnabled = true;
            this.checkLBoxPorcAlimento.Location = new System.Drawing.Point(12, 177);
            this.checkLBoxPorcAlimento.Name = "checkLBoxPorcAlimento";
            this.checkLBoxPorcAlimento.Size = new System.Drawing.Size(522, 94);
            this.checkLBoxPorcAlimento.TabIndex = 17;
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
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(12, 304);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(522, 86);
            this.txtBoxDescricao.TabIndex = 15;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 23);
            this.textBox1.TabIndex = 21;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(522, 23);
            this.textBox2.TabIndex = 23;
            // 
            // EditarDieta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrarCancelar);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.Controls.Add(this.checkLBoxPorcAlimento);
            this.Controls.Add(this.lvlPorAlimento);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Name = "EditarDieta";
            this.Text = "EditarDieta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCancelar;
        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.CheckedListBox checkLBoxPorcAlimento;
        private System.Windows.Forms.Label lvlPorAlimento;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBox2;
    }
}