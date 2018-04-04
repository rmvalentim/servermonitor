namespace PainelPingDinamico
{
    partial class JanelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarPainelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paineisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.paineisToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.paineisToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarPainelToolStripMenuItem,
            this.iniciarTodosToolStripMenuItem,
            this.pararTodosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // adicionarPainelToolStripMenuItem
            // 
            this.adicionarPainelToolStripMenuItem.Name = "adicionarPainelToolStripMenuItem";
            this.adicionarPainelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.adicionarPainelToolStripMenuItem.Text = "Adicionar Painel";
            this.adicionarPainelToolStripMenuItem.Click += new System.EventHandler(this.adicionarPainelToolStripMenuItem_Click);
            // 
            // paineisToolStripMenuItem
            // 
            this.paineisToolStripMenuItem.Name = "paineisToolStripMenuItem";
            this.paineisToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.paineisToolStripMenuItem.Text = "Paineis";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladoToolStripMenuItem});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // ladoToolStripMenuItem
            // 
            this.ladoToolStripMenuItem.Name = "ladoToolStripMenuItem";
            this.ladoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ladoToolStripMenuItem.Text = "Adicionar Paineis";
            this.ladoToolStripMenuItem.Click += new System.EventHandler(this.ladoToolStripMenuItem_Click);
            // 
            // iniciarTodosToolStripMenuItem
            // 
            this.iniciarTodosToolStripMenuItem.Name = "iniciarTodosToolStripMenuItem";
            this.iniciarTodosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.iniciarTodosToolStripMenuItem.Text = "Iniciar Todos";
            this.iniciarTodosToolStripMenuItem.Click += new System.EventHandler(this.iniciarTodosToolStripMenuItem_Click);
            // 
            // pararTodosToolStripMenuItem
            // 
            this.pararTodosToolStripMenuItem.Name = "pararTodosToolStripMenuItem";
            this.pararTodosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pararTodosToolStripMenuItem.Text = "Parar Todos";
            this.pararTodosToolStripMenuItem.Click += new System.EventHandler(this.pararTodosToolStripMenuItem_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "JanelaPrincipal";
            this.Text = "Painel de Monitoramento de Servidores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarPainelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paineisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararTodosToolStripMenuItem;
    }
}

