namespace cobOpus
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.comodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiComodos = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrasToolStripMenuItem,
            this.comodosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(784, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrasToolStripMenuItem2});
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.obrasToolStripMenuItem.Text = "Controle";
            // 
            // obrasToolStripMenuItem2
            // 
            this.obrasToolStripMenuItem2.Name = "obrasToolStripMenuItem2";
            this.obrasToolStripMenuItem2.Size = new System.Drawing.Size(105, 22);
            this.obrasToolStripMenuItem2.Text = "Obras";
            // 
            // comodosToolStripMenuItem
            // 
            this.comodosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadasToolStripMenuItem,
            this.tsmiComodos,
            this.produtosToolStripMenuItem,
            this.obrasToolStripMenuItem1});
            this.comodosToolStripMenuItem.Name = "comodosToolStripMenuItem";
            this.comodosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.comodosToolStripMenuItem.Text = "Cadastros";
            // 
            // atividadasToolStripMenuItem
            // 
            this.atividadasToolStripMenuItem.Name = "atividadasToolStripMenuItem";
            this.atividadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividadasToolStripMenuItem.Text = "Atividadas";
            // 
            // tsmiComodos
            // 
            this.tsmiComodos.Name = "tsmiComodos";
            this.tsmiComodos.Size = new System.Drawing.Size(180, 22);
            this.tsmiComodos.Text = "Cômodos";
            this.tsmiComodos.Click += new System.EventHandler(this.tsmiComodos_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // obrasToolStripMenuItem1
            // 
            this.obrasToolStripMenuItem1.Name = "obrasToolStripMenuItem1";
            this.obrasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.obrasToolStripMenuItem1.Text = "Obras";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 698);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.MinimumSize = new System.Drawing.Size(800, 736);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cobOpus 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiComodos;
        private System.Windows.Forms.ToolStripMenuItem atividadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}