
namespace DietCSharpForm
{
    partial class PacienteMain
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
            this.toolStripRefeicoes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRefeicoesPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPorcAlimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPorcAlimentosPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDieta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDietaPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripRefeicoes
            // 
            this.toolStripRefeicoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefeicoesPesquisar});
            this.toolStripRefeicoes.Name = "toolStripRefeicoes";
            this.toolStripRefeicoes.Size = new System.Drawing.Size(69, 20);
            this.toolStripRefeicoes.Text = "Refeições";
            // 
            // toolStripRefeicoesPesquisar
            // 
            this.toolStripRefeicoesPesquisar.Name = "toolStripRefeicoesPesquisar";
            this.toolStripRefeicoesPesquisar.Size = new System.Drawing.Size(124, 22);
            this.toolStripRefeicoesPesquisar.Text = "Pesquisar";
            // 
            // toolStripPorcAlimentos
            // 
            this.toolStripPorcAlimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPorcAlimentosPesquisar});
            this.toolStripPorcAlimentos.Name = "toolStripPorcAlimentos";
            this.toolStripPorcAlimentos.Size = new System.Drawing.Size(130, 20);
            this.toolStripPorcAlimentos.Text = "Poções de Alimentos";
            // 
            // toolStripPorcAlimentosPesquisar
            // 
            this.toolStripPorcAlimentosPesquisar.Name = "toolStripPorcAlimentosPesquisar";
            this.toolStripPorcAlimentosPesquisar.Size = new System.Drawing.Size(124, 22);
            this.toolStripPorcAlimentosPesquisar.Text = "Pesquisar";
            // 
            // toolStripDieta
            // 
            this.toolStripDieta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDietaPesquisar});
            this.toolStripDieta.Name = "toolStripDieta";
            this.toolStripDieta.Size = new System.Drawing.Size(46, 20);
            this.toolStripDieta.Text = "Dieta";
            // 
            // toolStripDietaPesquisar
            // 
            this.toolStripDietaPesquisar.Name = "toolStripDietaPesquisar";
            this.toolStripDietaPesquisar.Size = new System.Drawing.Size(124, 22);
            this.toolStripDietaPesquisar.Text = "Pesquisar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefeicoes,
            this.toolStripPorcAlimentos,
            this.toolStripDieta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PacienteMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PacienteMain";
            this.Text = "PacienteMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripRefeicoes;
        private System.Windows.Forms.ToolStripMenuItem toolStripRefeicoesPesquisar;
        private System.Windows.Forms.ToolStripMenuItem toolStripPorcAlimentos;
        private System.Windows.Forms.ToolStripMenuItem toolStripPorcAlimentosPesquisar;
        private System.Windows.Forms.ToolStripMenuItem toolStripDieta;
        private System.Windows.Forms.ToolStripMenuItem toolStripDietaPesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}