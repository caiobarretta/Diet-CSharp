
namespace DietCSharpForm
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripRefeicoes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRefeicoesCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRefeicoesPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPorcAlimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPorcAlimentosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPorcAlimentosPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDieta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDietaCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDietaPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPacienteCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPacientePesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomePerfil = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDieta = new System.Windows.Forms.GroupBox();
            this.treeViewPorcaoDeAlimento = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDieta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegistrodeAtividades = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rbBuchoCheio = new System.Windows.Forms.RadioButton();
            this.rbSatisfeito = new System.Windows.Forms.RadioButton();
            this.rbPasseiFome = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clbPorcaoDeAlimentosConsumido = new System.Windows.Forms.CheckedListBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDieta.SuspendLayout();
            this.gbRegistrodeAtividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefeicoes,
            this.toolStripPorcAlimentos,
            this.toolStripDieta,
            this.toolStripPaciente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripRefeicoes
            // 
            this.toolStripRefeicoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefeicoesCadastrar,
            this.toolStripRefeicoesPesquisar});
            this.toolStripRefeicoes.ForeColor = System.Drawing.Color.White;
            this.toolStripRefeicoes.Name = "toolStripRefeicoes";
            this.toolStripRefeicoes.Size = new System.Drawing.Size(88, 25);
            this.toolStripRefeicoes.Text = "Refeições";
            // 
            // toolStripRefeicoesCadastrar
            // 
            this.toolStripRefeicoesCadastrar.Name = "toolStripRefeicoesCadastrar";
            this.toolStripRefeicoesCadastrar.Size = new System.Drawing.Size(147, 26);
            this.toolStripRefeicoesCadastrar.Text = "Cadastrar";
            // 
            // toolStripRefeicoesPesquisar
            // 
            this.toolStripRefeicoesPesquisar.Name = "toolStripRefeicoesPesquisar";
            this.toolStripRefeicoesPesquisar.Size = new System.Drawing.Size(147, 26);
            this.toolStripRefeicoesPesquisar.Text = "Pesquisar";
            // 
            // toolStripPorcAlimentos
            // 
            this.toolStripPorcAlimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPorcAlimentosCadastrar,
            this.toolStripPorcAlimentosPesquisar});
            this.toolStripPorcAlimentos.ForeColor = System.Drawing.Color.White;
            this.toolStripPorcAlimentos.Name = "toolStripPorcAlimentos";
            this.toolStripPorcAlimentos.Size = new System.Drawing.Size(165, 25);
            this.toolStripPorcAlimentos.Text = "Poções de Alimentos";
            // 
            // toolStripPorcAlimentosCadastrar
            // 
            this.toolStripPorcAlimentosCadastrar.Name = "toolStripPorcAlimentosCadastrar";
            this.toolStripPorcAlimentosCadastrar.Size = new System.Drawing.Size(147, 26);
            this.toolStripPorcAlimentosCadastrar.Text = "Cadastrar";
            // 
            // toolStripPorcAlimentosPesquisar
            // 
            this.toolStripPorcAlimentosPesquisar.Name = "toolStripPorcAlimentosPesquisar";
            this.toolStripPorcAlimentosPesquisar.Size = new System.Drawing.Size(147, 26);
            this.toolStripPorcAlimentosPesquisar.Text = "Pesquisar";
            // 
            // toolStripDieta
            // 
            this.toolStripDieta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDietaCadastrar,
            this.toolStripDietaPesquisar});
            this.toolStripDieta.ForeColor = System.Drawing.Color.White;
            this.toolStripDieta.Name = "toolStripDieta";
            this.toolStripDieta.Size = new System.Drawing.Size(58, 25);
            this.toolStripDieta.Text = "Dieta";
            // 
            // toolStripDietaCadastrar
            // 
            this.toolStripDietaCadastrar.Name = "toolStripDietaCadastrar";
            this.toolStripDietaCadastrar.Size = new System.Drawing.Size(147, 26);
            this.toolStripDietaCadastrar.Text = "Cadastrar";
            // 
            // toolStripDietaPesquisar
            // 
            this.toolStripDietaPesquisar.Name = "toolStripDietaPesquisar";
            this.toolStripDietaPesquisar.Size = new System.Drawing.Size(147, 26);
            this.toolStripDietaPesquisar.Text = "Pesquisar";
            // 
            // toolStripPaciente
            // 
            this.toolStripPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPacienteCadastrar,
            this.toolStripPacientePesquisar});
            this.toolStripPaciente.ForeColor = System.Drawing.Color.White;
            this.toolStripPaciente.Name = "toolStripPaciente";
            this.toolStripPaciente.Size = new System.Drawing.Size(79, 25);
            this.toolStripPaciente.Text = "Paciente";
            // 
            // toolStripPacienteCadastrar
            // 
            this.toolStripPacienteCadastrar.Name = "toolStripPacienteCadastrar";
            this.toolStripPacienteCadastrar.Size = new System.Drawing.Size(147, 26);
            this.toolStripPacienteCadastrar.Text = "Cadastrar";
            // 
            // toolStripPacientePesquisar
            // 
            this.toolStripPacientePesquisar.Name = "toolStripPacientePesquisar";
            this.toolStripPacientePesquisar.Size = new System.Drawing.Size(147, 26);
            this.toolStripPacientePesquisar.Text = "Pesquisar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomePerfil);
            this.groupBox1.Controls.Add(this.lblNomeUsuario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // lblNomePerfil
            // 
            this.lblNomePerfil.AutoSize = true;
            this.lblNomePerfil.Location = new System.Drawing.Point(97, 68);
            this.lblNomePerfil.Name = "lblNomePerfil";
            this.lblNomePerfil.Size = new System.Drawing.Size(85, 21);
            this.lblNomePerfil.TabIndex = 3;
            this.lblNomePerfil.Text = "nomePerfil";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(97, 34);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(82, 21);
            this.lblNomeUsuario.TabIndex = 2;
            this.lblNomeUsuario.Text = "nomeUser";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Perfil:";
            // 
            // gbDieta
            // 
            this.gbDieta.Controls.Add(this.treeViewPorcaoDeAlimento);
            this.gbDieta.Controls.Add(this.label3);
            this.gbDieta.Controls.Add(this.lblDieta);
            this.gbDieta.Controls.Add(this.label1);
            this.gbDieta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbDieta.ForeColor = System.Drawing.Color.White;
            this.gbDieta.Location = new System.Drawing.Point(12, 167);
            this.gbDieta.Name = "gbDieta";
            this.gbDieta.Size = new System.Drawing.Size(397, 552);
            this.gbDieta.TabIndex = 3;
            this.gbDieta.TabStop = false;
            this.gbDieta.Text = "Dieta";
            // 
            // treeViewPorcaoDeAlimento
            // 
            this.treeViewPorcaoDeAlimento.Location = new System.Drawing.Point(22, 125);
            this.treeViewPorcaoDeAlimento.Name = "treeViewPorcaoDeAlimento";
            this.treeViewPorcaoDeAlimento.Size = new System.Drawing.Size(356, 395);
            this.treeViewPorcaoDeAlimento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porções de Alimento";
            // 
            // lblDieta
            // 
            this.lblDieta.AutoSize = true;
            this.lblDieta.Location = new System.Drawing.Point(81, 43);
            this.lblDieta.Name = "lblDieta";
            this.lblDieta.Size = new System.Drawing.Size(86, 21);
            this.lblDieta.TabIndex = 1;
            this.lblDieta.Text = "nomeDieta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dieta: ";
            // 
            // gbRegistrodeAtividades
            // 
            this.gbRegistrodeAtividades.Controls.Add(this.pictureBox3);
            this.gbRegistrodeAtividades.Controls.Add(this.pictureBox2);
            this.gbRegistrodeAtividades.Controls.Add(this.pictureBox1);
            this.gbRegistrodeAtividades.Controls.Add(this.btnCancelar);
            this.gbRegistrodeAtividades.Controls.Add(this.btnSalvar);
            this.gbRegistrodeAtividades.Controls.Add(this.label11);
            this.gbRegistrodeAtividades.Controls.Add(this.rbBuchoCheio);
            this.gbRegistrodeAtividades.Controls.Add(this.rbSatisfeito);
            this.gbRegistrodeAtividades.Controls.Add(this.rbPasseiFome);
            this.gbRegistrodeAtividades.Controls.Add(this.label10);
            this.gbRegistrodeAtividades.Controls.Add(this.txtComentario);
            this.gbRegistrodeAtividades.Controls.Add(this.label9);
            this.gbRegistrodeAtividades.Controls.Add(this.clbPorcaoDeAlimentosConsumido);
            this.gbRegistrodeAtividades.Controls.Add(this.monthCalendar);
            this.gbRegistrodeAtividades.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRegistrodeAtividades.ForeColor = System.Drawing.Color.White;
            this.gbRegistrodeAtividades.Location = new System.Drawing.Point(434, 45);
            this.gbRegistrodeAtividades.Name = "gbRegistrodeAtividades";
            this.gbRegistrodeAtividades.Size = new System.Drawing.Size(806, 674);
            this.gbRegistrodeAtividades.TabIndex = 4;
            this.gbRegistrodeAtividades.TabStop = false;
            this.gbRegistrodeAtividades.Text = "Registro de Atividades";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(723, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(723, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(723, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(607, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 42);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(607, 264);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 42);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Porção de Alimentos Consumidos:";
            // 
            // rbBuchoCheio
            // 
            this.rbBuchoCheio.AutoSize = true;
            this.rbBuchoCheio.ForeColor = System.Drawing.Color.Orange;
            this.rbBuchoCheio.Location = new System.Drawing.Point(609, 161);
            this.rbBuchoCheio.Name = "rbBuchoCheio";
            this.rbBuchoCheio.Size = new System.Drawing.Size(115, 25);
            this.rbBuchoCheio.TabIndex = 7;
            this.rbBuchoCheio.TabStop = true;
            this.rbBuchoCheio.Text = "Bucho Cheio";
            this.rbBuchoCheio.UseVisualStyleBackColor = true;
            // 
            // rbSatisfeito
            // 
            this.rbSatisfeito.AutoSize = true;
            this.rbSatisfeito.ForeColor = System.Drawing.Color.LightGreen;
            this.rbSatisfeito.Location = new System.Drawing.Point(609, 113);
            this.rbSatisfeito.Name = "rbSatisfeito";
            this.rbSatisfeito.Size = new System.Drawing.Size(92, 25);
            this.rbSatisfeito.TabIndex = 6;
            this.rbSatisfeito.TabStop = true;
            this.rbSatisfeito.Text = "Satisfeito";
            this.rbSatisfeito.UseVisualStyleBackColor = true;
            // 
            // rbPasseiFome
            // 
            this.rbPasseiFome.AutoSize = true;
            this.rbPasseiFome.ForeColor = System.Drawing.Color.Firebrick;
            this.rbPasseiFome.Location = new System.Drawing.Point(607, 64);
            this.rbPasseiFome.Name = "rbPasseiFome";
            this.rbPasseiFome.Size = new System.Drawing.Size(113, 25);
            this.rbPasseiFome.TabIndex = 5;
            this.rbPasseiFome.TabStop = true;
            this.rbPasseiFome.Text = "Passei Fome";
            this.rbPasseiFome.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sentimentos:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(12, 264);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(567, 96);
            this.txtComentario.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Comentários:";
            // 
            // clbPorcaoDeAlimentosConsumido
            // 
            this.clbPorcaoDeAlimentosConsumido.FormattingEnabled = true;
            this.clbPorcaoDeAlimentosConsumido.Location = new System.Drawing.Point(262, 48);
            this.clbPorcaoDeAlimentosConsumido.Name = "clbPorcaoDeAlimentosConsumido";
            this.clbPorcaoDeAlimentosConsumido.Size = new System.Drawing.Size(317, 148);
            this.clbPorcaoDeAlimentosConsumido.TabIndex = 1;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 34);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1252, 731);
            this.Controls.Add(this.gbRegistrodeAtividades);
            this.Controls.Add(this.gbDieta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDieta.ResumeLayout(false);
            this.gbDieta.PerformLayout();
            this.gbRegistrodeAtividades.ResumeLayout(false);
            this.gbRegistrodeAtividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripRefeicoes;
        private System.Windows.Forms.ToolStripMenuItem toolStripRefeicoesCadastrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripRefeicoesPesquisar;
        private System.Windows.Forms.ToolStripMenuItem toolStripPorcAlimentos;
        private System.Windows.Forms.ToolStripMenuItem toolStripPorcAlimentosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripPorcAlimentosPesquisar;
        private System.Windows.Forms.ToolStripMenuItem toolStripDieta;
        private System.Windows.Forms.ToolStripMenuItem toolStripDietaCadastrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripDietaPesquisar;
        private System.Windows.Forms.ToolStripMenuItem toolStripPaciente;
        private System.Windows.Forms.ToolStripMenuItem toolStripPacienteCadastrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripPacientePesquisar;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDieta;
        private System.Windows.Forms.Label lblDieta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbRegistrodeAtividades;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNomePerfil;
        private System.Windows.Forms.Label txtNomeUsuario;
        private System.Windows.Forms.CheckedListBox clbPorcaoDeAlimentosConsumido;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbBuchoCheio;
        private System.Windows.Forms.RadioButton rbSatisfeito;
        private System.Windows.Forms.RadioButton rbPasseiFome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TreeView treeViewPorcaoDeAlimento;
    }
}

