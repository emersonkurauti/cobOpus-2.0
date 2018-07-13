namespace cobOpus.View
{
    partial class frmCadProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cobProdutosTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobProdutosTableAdapter();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cdProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deFormulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdUnidadeMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cobUnidadeMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobUnidadeMedidaTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobUnidadeMedidaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobUnidadeMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobProdutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cobProdutosTableAdapter
            // 
            this.cobProdutosTableAdapter.ClearBeforeFill = true;
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
            this.cdProdutoDataGridViewTextBoxColumn,
            this.nmProdutoDataGridViewTextBoxColumn,
            this.deFormulaDataGridViewTextBoxColumn,
            this.vlProdutoDataGridViewTextBoxColumn,
            this.cdUnidadeMedidaDataGridViewTextBoxColumn});
            this.dgvDados.DataSource = this.cobProdutosBindingSource;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(0, 25);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(511, 384);
            this.dgvDados.TabIndex = 14;
            this.dgvDados.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellEndEdit);
            this.dgvDados.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDados_CellValidating);
            // 
            // cdProdutoDataGridViewTextBoxColumn
            // 
            this.cdProdutoDataGridViewTextBoxColumn.DataPropertyName = "cdProduto";
            this.cdProdutoDataGridViewTextBoxColumn.HeaderText = "cdProduto";
            this.cdProdutoDataGridViewTextBoxColumn.Name = "cdProdutoDataGridViewTextBoxColumn";
            this.cdProdutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nmProdutoDataGridViewTextBoxColumn
            // 
            this.nmProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmProdutoDataGridViewTextBoxColumn.DataPropertyName = "nmProduto";
            this.nmProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.nmProdutoDataGridViewTextBoxColumn.Name = "nmProdutoDataGridViewTextBoxColumn";
            // 
            // deFormulaDataGridViewTextBoxColumn
            // 
            this.deFormulaDataGridViewTextBoxColumn.DataPropertyName = "deFormula";
            this.deFormulaDataGridViewTextBoxColumn.HeaderText = "Fórmula Calc.";
            this.deFormulaDataGridViewTextBoxColumn.Name = "deFormulaDataGridViewTextBoxColumn";
            // 
            // vlProdutoDataGridViewTextBoxColumn
            // 
            this.vlProdutoDataGridViewTextBoxColumn.DataPropertyName = "vlProduto";
            dataGridViewCellStyle2.Format = "C2";
            this.vlProdutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.vlProdutoDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vlProdutoDataGridViewTextBoxColumn.Name = "vlProdutoDataGridViewTextBoxColumn";
            // 
            // cdUnidadeMedidaDataGridViewTextBoxColumn
            // 
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.DataPropertyName = "cdUnidadeMedida";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.DataSource = this.cobUnidadeMedidaBindingSource;
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.DisplayMember = "deUnidadeMedida";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.HeaderText = "Und. Medida";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.Name = "cdUnidadeMedidaDataGridViewTextBoxColumn";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.ValueMember = "cdUnidadeMedida";
            this.cdUnidadeMedidaDataGridViewTextBoxColumn.Width = 95;
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
            // cobProdutosBindingSource
            // 
            this.cobProdutosBindingSource.DataMember = "cobProdutos";
            this.cobProdutosBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobUnidadeMedidaTableAdapter
            // 
            this.cobUnidadeMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Controls.Add(this.dgvDados);
            this.Name = "frmCadProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmCadProdutos_Load);
            this.Controls.SetChildIndex(this.dgvDados, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobUnidadeMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobProdutosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cobDataBase_dbDataSetTableAdapters.cobProdutosTableAdapter cobProdutosTableAdapter;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.BindingSource cobProdutosBindingSource;
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private System.Windows.Forms.BindingSource cobUnidadeMedidaBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobUnidadeMedidaTableAdapter cobUnidadeMedidaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deFormulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cdUnidadeMedidaDataGridViewTextBoxColumn;
    }
}
