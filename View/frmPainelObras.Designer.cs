namespace cobOpus.View
{
    partial class frmPainelObras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelObras));
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobObrasTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobObrasTableAdapter();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.pnCards = new System.Windows.Forms.Panel();
            this.flpPainel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnNovaObra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.pnCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // cobDataBase_dbDataSet
            // 
            this.cobDataBase_dbDataSet.DataSetName = "cobDataBase_dbDataSet";
            this.cobDataBase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobObrasTableAdapter
            // 
            this.cobObrasTableAdapter.ClearBeforeFill = true;
            // 
            // pnBotoes
            // 
            this.pnBotoes.BackColor = System.Drawing.Color.White;
            this.pnBotoes.Controls.Add(this.btnNovaObra);
            this.pnBotoes.Controls.Add(this.btnAtualizar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(751, 31);
            this.pnBotoes.TabIndex = 3;
            // 
            // pnCards
            // 
            this.pnCards.Controls.Add(this.flpPainel);
            this.pnCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCards.Location = new System.Drawing.Point(0, 31);
            this.pnCards.Name = "pnCards";
            this.pnCards.Size = new System.Drawing.Size(751, 475);
            this.pnCards.TabIndex = 4;
            // 
            // flpPainel
            // 
            this.flpPainel.BackColor = System.Drawing.Color.White;
            this.flpPainel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPainel.Location = new System.Drawing.Point(0, 0);
            this.flpPainel.Name = "flpPainel";
            this.flpPainel.Size = new System.Drawing.Size(751, 475);
            this.flpPainel.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Azure;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(99, 3);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 25);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnNovaObra
            // 
            this.btnNovaObra.BackColor = System.Drawing.Color.Azure;
            this.btnNovaObra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovaObra.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaObra.Image")));
            this.btnNovaObra.Location = new System.Drawing.Point(3, 3);
            this.btnNovaObra.Name = "btnNovaObra";
            this.btnNovaObra.Size = new System.Drawing.Size(90, 25);
            this.btnNovaObra.TabIndex = 1;
            this.btnNovaObra.Text = "Nova obra";
            this.btnNovaObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovaObra.UseVisualStyleBackColor = false;
            this.btnNovaObra.Click += new System.EventHandler(this.btnNovaObra_Click);
            // 
            // frmPainelObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 506);
            this.Controls.Add(this.pnCards);
            this.Controls.Add(this.pnBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelObras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de obras";
            this.Load += new System.EventHandler(this.frmPainelObras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.pnCards.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private cobDataBase_dbDataSetTableAdapters.cobObrasTableAdapter cobObrasTableAdapter;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Panel pnCards;
        private System.Windows.Forms.FlowLayoutPanel flpPainel;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNovaObra;
    }
}