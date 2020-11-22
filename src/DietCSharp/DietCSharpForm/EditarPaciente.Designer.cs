
namespace DietCSharpForm
{
    partial class EditarPaciente
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.listBoxDieta = new System.Windows.Forms.ListBox();
            this.lblDieta = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
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
            this.btnCadastrarCancelar.Location = new System.Drawing.Point(452, 353);
            this.btnCadastrarCancelar.Name = "btnCadastrarCancelar";
            this.btnCadastrarCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarCancelar.TabIndex = 21;
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
            this.btnCadastrarSalvar.Location = new System.Drawing.Point(364, 353);
            this.btnCadastrarSalvar.Name = "btnCadastrarSalvar";
            this.btnCadastrarSalvar.Size = new System.Drawing.Size(82, 34);
            this.btnCadastrarSalvar.TabIndex = 20;
            this.btnCadastrarSalvar.Text = "Salvar";
            this.btnCadastrarSalvar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 103);
            this.textBox1.TabIndex = 19;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(14, 226);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "Descrição";
            // 
            // listBoxDieta
            // 
            this.listBoxDieta.FormattingEnabled = true;
            this.listBoxDieta.ItemHeight = 15;
            this.listBoxDieta.Location = new System.Drawing.Point(12, 142);
            this.listBoxDieta.Name = "listBoxDieta";
            this.listBoxDieta.Size = new System.Drawing.Size(522, 64);
            this.listBoxDieta.TabIndex = 17;
            // 
            // lblDieta
            // 
            this.lblDieta.AutoSize = true;
            this.lblDieta.Location = new System.Drawing.Point(12, 124);
            this.lblDieta.Name = "lblDieta";
            this.lblDieta.Size = new System.Drawing.Size(34, 15);
            this.lblDieta.TabIndex = 16;
            this.lblDieta.Text = "Dieta";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 83);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(522, 23);
            this.textBoxNome.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Codigo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(522, 23);
            this.textBox2.TabIndex = 24;
            // 
            // EditarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCadastrarCancelar);
            this.Controls.Add(this.btnCadastrarSalvar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.listBoxDieta);
            this.Controls.Add(this.lblDieta);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.lblNome);
            this.Name = "EditarPaciente";
            this.Text = "EditarPaciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCancelar;
        private System.Windows.Forms.Button btnCadastrarSalvar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ListBox listBoxDieta;
        private System.Windows.Forms.Label lblDieta;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBox2;
    }
}