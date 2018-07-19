namespace cobOpus.View
{
    partial class frmCadComodos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadComodos));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cdComodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmComodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobComodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobComodosTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobComodosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobComodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.AutoGenerateColumns = false;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdComodoDataGridViewTextBoxColumn,
            this.nmComodoDataGridViewTextBoxColumn});
            this.dgvDados.DataSource = this.cobComodosBindingSource;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(0, 25);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(511, 384);
            this.dgvDados.TabIndex = 14;
            this.dgvDados.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDados_CellValidating);
            // 
            // cdComodoDataGridViewTextBoxColumn
            // 
            this.cdComodoDataGridViewTextBoxColumn.DataPropertyName = "cdComodo";
            this.cdComodoDataGridViewTextBoxColumn.HeaderText = "cdComodo";
            this.cdComodoDataGridViewTextBoxColumn.Name = "cdComodoDataGridViewTextBoxColumn";
            this.cdComodoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nmComodoDataGridViewTextBoxColumn
            // 
            this.nmComodoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmComodoDataGridViewTextBoxColumn.DataPropertyName = "nmComodo";
            this.nmComodoDataGridViewTextBoxColumn.HeaderText = "Cômodo";
            this.nmComodoDataGridViewTextBoxColumn.Name = "nmComodoDataGridViewTextBoxColumn";
            // 
            // cobComodosBindingSource
            // 
            this.cobComodosBindingSource.DataMember = "cobComodos";
            this.cobComodosBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobDataBase_dbDataSet
            // 
            this.cobDataBase_dbDataSet.DataSetName = "cobDataBase_dbDataSet";
            this.cobDataBase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobComodosTableAdapter
            // 
            this.cobComodosTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadComodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Controls.Add(this.dgvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadComodos";
            this.Text = "Cômodos";
            this.Load += new System.EventHandler(this.frmCadComodos_Load);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobComodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private cobDataBase_dbDataSetTableAdapters.cobComodosTableAdapter cobComodosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdComodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmComodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cobComodosBindingSource;
    }
}
