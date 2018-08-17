namespace cobOpus.View.Componentes
{
    partial class ucCardObra
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbObra = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbObra
            // 
            this.lbObra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObra.Location = new System.Drawing.Point(3, 4);
            this.lbObra.Name = "lbObra";
            this.lbObra.Size = new System.Drawing.Size(344, 15);
            this.lbObra.TabIndex = 0;
            this.lbObra.Text = "Descrição resumida da obra";
            this.lbObra.MouseEnter += new System.EventHandler(this.ucCardObra_MouseEnter);
            this.lbObra.MouseLeave += new System.EventHandler(this.ucCardObra_MouseLeave);
            // 
            // lbCliente
            // 
            this.lbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(3, 21);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(343, 12);
            this.lbCliente.TabIndex = 1;
            this.lbCliente.Text = "Nome do cliente";
            this.lbCliente.MouseEnter += new System.EventHandler(this.ucCardObra_MouseEnter);
            this.lbCliente.MouseLeave += new System.EventHandler(this.ucCardObra_MouseLeave);
            // 
            // lbEndereco
            // 
            this.lbEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(3, 36);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(343, 12);
            this.lbEndereco.TabIndex = 2;
            this.lbEndereco.Text = "Endereço do cliente";
            this.lbEndereco.MouseEnter += new System.EventHandler(this.ucCardObra_MouseEnter);
            this.lbEndereco.MouseLeave += new System.EventHandler(this.ucCardObra_MouseLeave);
            // 
            // ucCardObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbCliente);
            this.Controls.Add(this.lbObra);
            this.Name = "ucCardObra";
            this.Load += new System.EventHandler(this.ucCardObra_Load);
            this.MouseEnter += new System.EventHandler(this.ucCardObra_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucCardObra_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbObra;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbEndereco;
    }
}
