
namespace DietCSharpForm
{
    partial class Editar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBoxCod = new System.Windows.Forms.TextBox();
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPesquisarDescricao = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEditarSalvar = new System.Windows.Forms.Button();
            this.btnEditarCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // txtBoxCod
            // 
            this.txtBoxCod.Location = new System.Drawing.Point(12, 27);
            this.txtBoxCod.Name = "txtBoxCod";
            this.txtBoxCod.Size = new System.Drawing.Size(479, 23);
            this.txtBoxCod.TabIndex = 1;
            // 
            // lblPesquisaNome
            // 
            this.lblPesquisaNome.AutoSize = true;
            this.lblPesquisaNome.Location = new System.Drawing.Point(12, 65);
            this.lblPesquisaNome.Name = "lblPesquisaNome";
            this.lblPesquisaNome.Size = new System.Drawing.Size(40, 15);
            this.lblPesquisaNome.TabIndex = 2;
            this.lblPesquisaNome.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(479, 23);
            this.textBox2.TabIndex = 3;
            // 
            // lblPesquisarDescricao
            // 
            this.lblPesquisarDescricao.AutoSize = true;
            this.lblPesquisarDescricao.Location = new System.Drawing.Point(12, 125);
            this.lblPesquisarDescricao.Name = "lblPesquisarDescricao";
            this.lblPesquisarDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblPesquisarDescricao.TabIndex = 4;
            this.lblPesquisarDescricao.Text = "Descrição";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 143);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(479, 149);
            this.textBox3.TabIndex = 5;
            // 
            // btnEditarSalvar
            // 
            this.btnEditarSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarSalvar.Location = new System.Drawing.Point(311, 298);
            this.btnEditarSalvar.Name = "btnEditarSalvar";
            this.btnEditarSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnEditarSalvar.TabIndex = 6;
            this.btnEditarSalvar.Text = "Salvar";
            this.btnEditarSalvar.UseVisualStyleBackColor = false;
            // 
            // btnEditarCancelar
            // 
            this.btnEditarCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEditarCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditarCancelar.Location = new System.Drawing.Point(409, 298);
            this.btnEditarCancelar.Name = "btnEditarCancelar";
            this.btnEditarCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnEditarCancelar.TabIndex = 7;
            this.btnEditarCancelar.Text = "Cancelar";
            this.btnEditarCancelar.UseVisualStyleBackColor = false;
            this.btnEditarCancelar.Click += new System.EventHandler(this.btnEditarCancelar_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 344);
            this.Controls.Add(this.btnEditarCancelar);
            this.Controls.Add(this.btnEditarSalvar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPesquisarDescricao);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPesquisaNome);
            this.Controls.Add(this.txtBoxCod);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Editar";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBoxCod;
        private System.Windows.Forms.Label lblPesquisaNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPesquisarDescricao;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnEditarSalvar;
        private System.Windows.Forms.Button btnEditarCancelar;
    }
}