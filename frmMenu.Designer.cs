namespace cobOpus
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnNavegacao
            // 
            this.pnNavegacao.AutoSize = true;
            this.pnNavegacao.BackColor = System.Drawing.Color.DimGray;
            this.pnNavegacao.Size = new System.Drawing.Size(784, 24);
            // 
            // txtNavegacao
            // 
            this.txtNavegacao.Visible = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMenu";
            this.Text = "CobOpus 2.0";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnNavegacao.ResumeLayout(false);
            this.pnNavegacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
