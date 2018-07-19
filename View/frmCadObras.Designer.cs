namespace cobOpus.View
{
    partial class frmCadObras
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cobObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobObrasTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobObrasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNmObra = new System.Windows.Forms.TextBox();
            this.txtDeObra = new System.Windows.Forms.TextBox();
            this.txtDeEndereco = new System.Windows.Forms.TextBox();
            this.txtNmCliente = new System.Windows.Forms.TextBox();
            this.cdObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deEnderecoObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmClienteObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnControle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcCadastro.SuspendLayout();
            this.tpTabela.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tpTabela
            // 
            this.tpTabela.Controls.Add(this.dgvDados);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Controls.Add(this.txtNmCliente);
            this.tpFormulario.Controls.Add(this.txtDeEndereco);
            this.tpFormulario.Controls.Add(this.txtDeObra);
            this.tpFormulario.Controls.Add(this.txtNmObra);
            this.tpFormulario.Controls.Add(this.label4);
            this.tpFormulario.Controls.Add(this.label3);
            this.tpFormulario.Controls.Add(this.label2);
            this.tpFormulario.Controls.Add(this.label1);
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
            this.cdObraDataGridViewTextBoxColumn,
            this.nmObraDataGridViewTextBoxColumn,
            this.deObraDataGridViewTextBoxColumn,
            this.deEnderecoObraDataGridViewTextBoxColumn,
            this.nmClienteObraDataGridViewTextBoxColumn,
            this.btnControle});
            this.dgvDados.DataSource = this.cobObrasBindingSource;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(497, 352);
            this.dgvDados.TabIndex = 16;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // cobObrasBindingSource
            // 
            this.cobObrasBindingSource.DataMember = "cobObras";
            this.cobObrasBindingSource.DataSource = this.cobDataBase_dbDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição resumida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição detalhada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente";
            // 
            // txtNmObra
            // 
            this.txtNmObra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmObra.Location = new System.Drawing.Point(6, 19);
            this.txtNmObra.Name = "txtNmObra";
            this.txtNmObra.Size = new System.Drawing.Size(489, 20);
            this.txtNmObra.TabIndex = 4;
            // 
            // txtDeObra
            // 
            this.txtDeObra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeObra.Location = new System.Drawing.Point(6, 58);
            this.txtDeObra.Multiline = true;
            this.txtDeObra.Name = "txtDeObra";
            this.txtDeObra.Size = new System.Drawing.Size(489, 50);
            this.txtDeObra.TabIndex = 5;
            // 
            // txtDeEndereco
            // 
            this.txtDeEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeEndereco.Location = new System.Drawing.Point(6, 127);
            this.txtDeEndereco.Name = "txtDeEndereco";
            this.txtDeEndereco.Size = new System.Drawing.Size(489, 20);
            this.txtDeEndereco.TabIndex = 6;
            // 
            // txtNmCliente
            // 
            this.txtNmCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmCliente.Location = new System.Drawing.Point(6, 166);
            this.txtNmCliente.Name = "txtNmCliente";
            this.txtNmCliente.Size = new System.Drawing.Size(489, 20);
            this.txtNmCliente.TabIndex = 7;
            // 
            // cdObraDataGridViewTextBoxColumn
            // 
            this.cdObraDataGridViewTextBoxColumn.DataPropertyName = "cdObra";
            this.cdObraDataGridViewTextBoxColumn.HeaderText = "cdObra";
            this.cdObraDataGridViewTextBoxColumn.Name = "cdObraDataGridViewTextBoxColumn";
            this.cdObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdObraDataGridViewTextBoxColumn.Visible = false;
            this.cdObraDataGridViewTextBoxColumn.Width = 50;
            // 
            // nmObraDataGridViewTextBoxColumn
            // 
            this.nmObraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmObraDataGridViewTextBoxColumn.DataPropertyName = "nmObra";
            this.nmObraDataGridViewTextBoxColumn.HeaderText = "Obra";
            this.nmObraDataGridViewTextBoxColumn.Name = "nmObraDataGridViewTextBoxColumn";
            this.nmObraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deObraDataGridViewTextBoxColumn
            // 
            this.deObraDataGridViewTextBoxColumn.DataPropertyName = "deObra";
            this.deObraDataGridViewTextBoxColumn.HeaderText = "deObra";
            this.deObraDataGridViewTextBoxColumn.Name = "deObraDataGridViewTextBoxColumn";
            this.deObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.deObraDataGridViewTextBoxColumn.Visible = false;
            // 
            // deEnderecoObraDataGridViewTextBoxColumn
            // 
            this.deEnderecoObraDataGridViewTextBoxColumn.DataPropertyName = "deEnderecoObra";
            this.deEnderecoObraDataGridViewTextBoxColumn.HeaderText = "deEnderecoObra";
            this.deEnderecoObraDataGridViewTextBoxColumn.Name = "deEnderecoObraDataGridViewTextBoxColumn";
            this.deEnderecoObraDataGridViewTextBoxColumn.ReadOnly = true;
            this.deEnderecoObraDataGridViewTextBoxColumn.Visible = false;
            // 
            // nmClienteObraDataGridViewTextBoxColumn
            // 
            this.nmClienteObraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmClienteObraDataGridViewTextBoxColumn.DataPropertyName = "nmClienteObra";
            this.nmClienteObraDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nmClienteObraDataGridViewTextBoxColumn.Name = "nmClienteObraDataGridViewTextBoxColumn";
            this.nmClienteObraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnControle
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnControle.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnControle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControle.HeaderText = "";
            this.btnControle.Name = "btnControle";
            this.btnControle.ReadOnly = true;
            this.btnControle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnControle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnControle.Text = "Gerenciar";
            this.btnControle.ToolTipText = "Gerenciar";
            this.btnControle.UseColumnTextForButtonValue = true;
            this.btnControle.Width = 75;
            // 
            // frmCadObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Name = "frmCadObras";
            this.Text = "Obras";
            this.Load += new System.EventHandler(this.frmCadObras_Load);
            this.tcCadastro.ResumeLayout(false);
            this.tpTabela.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.tpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private System.Windows.Forms.BindingSource cobObrasBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobObrasTableAdapter cobObrasTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNmCliente;
        private System.Windows.Forms.TextBox txtDeEndereco;
        private System.Windows.Forms.TextBox txtDeObra;
        private System.Windows.Forms.TextBox txtNmObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deEnderecoObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmClienteObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnControle;
    }
}
