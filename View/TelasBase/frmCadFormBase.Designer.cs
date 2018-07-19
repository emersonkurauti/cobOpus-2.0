namespace cobOpus.View.TelasBase
{
    partial class frmCadFormBase
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
            this.tcCadastro = new System.Windows.Forms.TabControl();
            this.tpTabela = new System.Windows.Forms.TabPage();
            this.tpFormulario = new System.Windows.Forms.TabPage();
            this.tcCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCadastro
            // 
            this.tcCadastro.Controls.Add(this.tpTabela);
            this.tcCadastro.Controls.Add(this.tpFormulario);
            this.tcCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCadastro.Location = new System.Drawing.Point(0, 25);
            this.tcCadastro.Name = "tcCadastro";
            this.tcCadastro.SelectedIndex = 0;
            this.tcCadastro.Size = new System.Drawing.Size(511, 384);
            this.tcCadastro.TabIndex = 14;
            // 
            // tpTabela
            // 
            this.tpTabela.Location = new System.Drawing.Point(4, 22);
            this.tpTabela.Name = "tpTabela";
            this.tpTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabela.Size = new System.Drawing.Size(503, 358);
            this.tpTabela.TabIndex = 0;
            this.tpTabela.Text = "Tabela";
            this.tpTabela.UseVisualStyleBackColor = true;
            // 
            // tpFormulario
            // 
            this.tpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tpFormulario.Name = "tpFormulario";
            this.tpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulario.Size = new System.Drawing.Size(503, 358);
            this.tpFormulario.TabIndex = 1;
            this.tpFormulario.Text = "Formulário";
            this.tpFormulario.UseVisualStyleBackColor = true;
            // 
            // frmCadFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Controls.Add(this.tcCadastro);
            this.Name = "frmCadFormBase";
            this.Controls.SetChildIndex(this.tcCadastro, 0);
            this.tcCadastro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcCadastro;
        private System.Windows.Forms.TabPage tpTabela;
        private System.Windows.Forms.TabPage tpFormulario;
    }
}
