namespace cobOpus
{
    partial class frmMenuBasico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuBasico));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pnNavegacao = new System.Windows.Forms.Panel();
            this.txtNavegacao = new System.Windows.Forms.TextBox();
            this.menuTelas = new System.Windows.Forms.MenuStrip();
            this.statusStrip.SuspendLayout();
            this.pnNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(39, 17);
            this.tslStatus.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // pnNavegacao
            // 
            this.pnNavegacao.BackColor = System.Drawing.Color.White;
            this.pnNavegacao.Controls.Add(this.txtNavegacao);
            this.pnNavegacao.Controls.Add(this.menuTelas);
            this.pnNavegacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNavegacao.Location = new System.Drawing.Point(0, 24);
            this.pnNavegacao.Name = "pnNavegacao";
            this.pnNavegacao.Size = new System.Drawing.Size(784, 43);
            this.pnNavegacao.TabIndex = 4;
            // 
            // txtNavegacao
            // 
            this.txtNavegacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNavegacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNavegacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNavegacao.Location = new System.Drawing.Point(0, 0);
            this.txtNavegacao.Name = "txtNavegacao";
            this.txtNavegacao.Size = new System.Drawing.Size(784, 20);
            this.txtNavegacao.TabIndex = 8;
            // 
            // menuTelas
            // 
            this.menuTelas.BackColor = System.Drawing.Color.Gainsboro;
            this.menuTelas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuTelas.Location = new System.Drawing.Point(0, 19);
            this.menuTelas.Name = "menuTelas";
            this.menuTelas.Size = new System.Drawing.Size(784, 24);
            this.menuTelas.TabIndex = 7;
            this.menuTelas.Text = "menuStrip1";
            // 
            // frmMenuBasico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.pnNavegacao);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmMenuBasico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuBasico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMenuBasico_KeyUp);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnNavegacao.ResumeLayout(false);
            this.pnNavegacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripStatusLabel tslStatus;
        public System.Windows.Forms.Panel pnNavegacao;
        public System.Windows.Forms.MenuStrip menuTelas;
        public System.Windows.Forms.TextBox txtNavegacao;
    }
}



