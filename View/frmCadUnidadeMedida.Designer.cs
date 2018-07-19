namespace cobOpus.View
{
    partial class frmCadUnidadesMedida
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cdUnidadeMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deUnidadeMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobUnidadeMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobUnidadeMedidaTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobUnidadeMedidaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobUnidadeMedidaBindingSource)).BeginInit();
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
            this.cdUnidadeMedidaDataGridViewTextBoxColumn,
            this.deUnidadeMedidaDataGridViewTextBoxColumn});
            this.dgvDados.DataSource = this.cobUnidadeMedidaBindingSource;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(0, 25);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(511, 384);
            this.dgvDados.TabIndex = 15;
            this.dgvDados.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDados_CellValidating);
            // 
            // cdUnidadeMedidaDataGridViewTextBoxColumn
            // 
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.DataPropertyName = "cdUnidadeMedida";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.HeaderText = "cdUnidadeMedida";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.Name = "cdUnidadeMedidaDataGridViewTextBoxColumn";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // deUnidadeMedidaDataGridViewTextBoxColumn
            // 
            this.deUnidadeMedidaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deUnidadeMedidaDataGridViewTextBoxColumn.DataPropertyName = "deUnidadeMedida";
            this.deUnidadeMedidaDataGridViewTextBoxColumn.HeaderText = "Unidade de medida";
            this.deUnidadeMedidaDataGridViewTextBoxColumn.Name = "deUnidadeMedidaDataGridViewTextBoxColumn";
            // 
            // cobUnidadeMedidaBindingSource
            // 
            this.cobUnidadeMedidaBindingSource.DataMember = "cobUnidadeMedida";
            this.cobUnidadeMedidaBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobDataBase_dbDataSet
            // 
            this.cobDataBase_dbDataSet.DataSetName = "cobDataBase_dbDataSet";
            this.cobDataBase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobUnidadeMedidaTableAdapter
            // 
            this.cobUnidadeMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadUnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Controls.Add(this.dgvDados);
            this.Name = "frmCadUnidadesMedida";
            this.Text = "Unidades de medida";
            this.Load += new System.EventHandler(this.frmCadUnidadeMedida_Load);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobUnidadeMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private System.Windows.Forms.BindingSource cobUnidadeMedidaBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobUnidadeMedidaTableAdapter cobUnidadeMedidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdUnidadeMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deUnidadeMedidaDataGridViewTextBoxColumn;
    }
}
