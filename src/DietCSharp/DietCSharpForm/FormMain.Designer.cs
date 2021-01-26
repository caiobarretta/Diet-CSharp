
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefeicoes,
            this.toolStripPorcAlimentos,
            this.toolStripDieta,
            this.toolStripPaciente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripRefeicoes
            // 
            this.toolStripRefeicoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefeicoesCadastrar,
            this.toolStripRefeicoesPesquisar});
            this.toolStripRefeicoes.Name = "toolStripRefeicoes";
            this.toolStripRefeicoes.Size = new System.Drawing.Size(60, 18);
            this.toolStripRefeicoes.Text = "Refeições";
            // 
            // toolStripRefeicoesCadastrar
            // 
            this.toolStripRefeicoesCadastrar.Name = "toolStripRefeicoesCadastrar";
            this.toolStripRefeicoesCadastrar.Size = new System.Drawing.Size(125, 26);
            this.toolStripRefeicoesCadastrar.Text = "Cadastrar";
            // 
            // toolStripRefeicoesPesquisar
            // 
            this.toolStripRefeicoesPesquisar.Name = "toolStripRefeicoesPesquisar";
            this.toolStripRefeicoesPesquisar.Size = new System.Drawing.Size(125, 26);
            this.toolStripRefeicoesPesquisar.Text = "Pesquisar";
            // 
            // toolStripPorcAlimentos
            // 
            this.toolStripPorcAlimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPorcAlimentosCadastrar,
            this.toolStripPorcAlimentosPesquisar});
            this.toolStripPorcAlimentos.Name = "toolStripPorcAlimentos";
            this.toolStripPorcAlimentos.Size = new System.Drawing.Size(111, 18);
            this.toolStripPorcAlimentos.Text = "Poções de Alimentos";
            // 
            // toolStripPorcAlimentosCadastrar
            // 
            this.toolStripPorcAlimentosCadastrar.Name = "toolStripPorcAlimentosCadastrar";
            this.toolStripPorcAlimentosCadastrar.Size = new System.Drawing.Size(125, 26);
            this.toolStripPorcAlimentosCadastrar.Text = "Cadastrar";
            // 
            // toolStripPorcAlimentosPesquisar
            // 
            this.toolStripPorcAlimentosPesquisar.Name = "toolStripPorcAlimentosPesquisar";
            this.toolStripPorcAlimentosPesquisar.Size = new System.Drawing.Size(125, 26);
            this.toolStripPorcAlimentosPesquisar.Text = "Pesquisar";
            // 
            // toolStripDieta
            // 
            this.toolStripDieta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDietaCadastrar,
            this.toolStripDietaPesquisar});
            this.toolStripDieta.Name = "toolStripDieta";
            this.toolStripDieta.Size = new System.Drawing.Size(41, 18);
            this.toolStripDieta.Text = "Dieta";
            // 
            // toolStripDietaCadastrar
            // 
            this.toolStripDietaCadastrar.Name = "toolStripDietaCadastrar";
            this.toolStripDietaCadastrar.Size = new System.Drawing.Size(125, 26);
            this.toolStripDietaCadastrar.Text = "Cadastrar";
            // 
            // toolStripDietaPesquisar
            // 
            this.toolStripDietaPesquisar.Name = "toolStripDietaPesquisar";
            this.toolStripDietaPesquisar.Size = new System.Drawing.Size(125, 26);
            this.toolStripDietaPesquisar.Text = "Pesquisar";
            // 
            // toolStripPaciente
            // 
            this.toolStripPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPacienteCadastrar,
            this.toolStripPacientePesquisar});
            this.toolStripPaciente.Name = "toolStripPaciente";
            this.toolStripPaciente.Size = new System.Drawing.Size(56, 18);
            this.toolStripPaciente.Text = "Paciente";
            // 
            // toolStripPacienteCadastrar
            // 
            this.toolStripPacienteCadastrar.Name = "toolStripPacienteCadastrar";
            this.toolStripPacienteCadastrar.Size = new System.Drawing.Size(125, 26);
            this.toolStripPacienteCadastrar.Text = "Cadastrar";
            // 
            // toolStripPacientePesquisar
            // 
            this.toolStripPacientePesquisar.Name = "toolStripPacientePesquisar";
            this.toolStripPacientePesquisar.Size = new System.Drawing.Size(125, 26);
            this.toolStripPacientePesquisar.Text = "Pesquisar";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 1063);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

