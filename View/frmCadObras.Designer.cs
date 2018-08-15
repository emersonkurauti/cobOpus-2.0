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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadObras));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cdObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deEnderecoObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmClienteObraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnControle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cobObrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobObrasTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobObrasTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtNmCliente = new System.Windows.Forms.TextBox();
            this.txtDeEndereco = new System.Windows.Forms.TextBox();
            this.txtDeObra = new System.Windows.Forms.TextBox();
            this.txtNmObra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvObraComodo = new System.Windows.Forms.DataGridView();
            this.cobObraComodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnObraComodo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cobComodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobComodosTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobComodosTableAdapter();
            this.cobObraComodoTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobObraComodoTableAdapter();
            this.fKcobObrascobObraComodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cdObraDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdComodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMetroLinearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVolumeTetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVolumePisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCadastro.SuspendLayout();
            this.tpTabela.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobObrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObraComodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobObraComodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnObraComodo)).BeginInit();
            this.bnObraComodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobComodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKcobObrascobObraComodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(645, 431);
            // 
            // tpTabela
            // 
            this.tpTabela.Controls.Add(this.dgvDados);
            this.tpTabela.Size = new System.Drawing.Size(637, 405);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Controls.Add(this.splitContainer1);
            this.tpFormulario.Size = new System.Drawing.Size(637, 405);
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
            this.dgvDados.Size = new System.Drawing.Size(631, 399);
            this.dgvDados.TabIndex = 16;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtNmCliente);
            this.splitContainer1.Panel1.Controls.Add(this.txtDeEndereco);
            this.splitContainer1.Panel1.Controls.Add(this.txtDeObra);
            this.splitContainer1.Panel1.Controls.Add(this.txtNmObra);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvObraComodo);
            this.splitContainer1.Panel2.Controls.Add(this.bnObraComodo);
            this.splitContainer1.Size = new System.Drawing.Size(631, 399);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtNmCliente
            // 
            this.txtNmCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmCliente.Location = new System.Drawing.Point(8, 174);
            this.txtNmCliente.Name = "txtNmCliente";
            this.txtNmCliente.Size = new System.Drawing.Size(618, 20);
            this.txtNmCliente.TabIndex = 15;
            // 
            // txtDeEndereco
            // 
            this.txtDeEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeEndereco.Location = new System.Drawing.Point(8, 135);
            this.txtDeEndereco.Name = "txtDeEndereco";
            this.txtDeEndereco.Size = new System.Drawing.Size(618, 20);
            this.txtDeEndereco.TabIndex = 14;
            // 
            // txtDeObra
            // 
            this.txtDeObra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeObra.Location = new System.Drawing.Point(8, 64);
            this.txtDeObra.Multiline = true;
            this.txtDeObra.Name = "txtDeObra";
            this.txtDeObra.Size = new System.Drawing.Size(618, 52);
            this.txtDeObra.TabIndex = 13;
            // 
            // txtNmObra
            // 
            this.txtNmObra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNmObra.Location = new System.Drawing.Point(8, 25);
            this.txtNmObra.Name = "txtNmObra";
            this.txtNmObra.Size = new System.Drawing.Size(618, 20);
            this.txtNmObra.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descrição detalhada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição resumida";
            // 
            // dgvObraComodo
            // 
            this.dgvObraComodo.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvObraComodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObraComodo.AutoGenerateColumns = false;
            this.dgvObraComodo.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvObraComodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObraComodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdObraDataGridViewTextBoxColumn1,
            this.cdComodoDataGridViewTextBoxColumn,
            this.nAreaDataGridViewTextBoxColumn,
            this.nMetroLinearDataGridViewTextBoxColumn,
            this.nVolumeTetoDataGridViewTextBoxColumn,
            this.nVolumePisoDataGridViewTextBoxColumn});
            this.dgvObraComodo.DataSource = this.fKcobObrascobObraComodoBindingSource;
            this.dgvObraComodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObraComodo.Location = new System.Drawing.Point(0, 25);
            this.dgvObraComodo.Name = "dgvObraComodo";
            this.dgvObraComodo.Size = new System.Drawing.Size(631, 165);
            this.dgvObraComodo.TabIndex = 23;
            // 
            // cobObraComodoBindingSource
            // 
            this.cobObraComodoBindingSource.DataMember = "cobObraComodo";
            this.cobObraComodoBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // bnObraComodo
            // 
            this.bnObraComodo.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bnObraComodo.BindingSource = this.fKcobObrascobObraComodoBindingSource;
            this.bnObraComodo.CountItem = this.bindingNavigatorCountItem1;
            this.bnObraComodo.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bnObraComodo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bnObraComodo.Location = new System.Drawing.Point(0, 0);
            this.bnObraComodo.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bnObraComodo.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bnObraComodo.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bnObraComodo.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bnObraComodo.Name = "bnObraComodo";
            this.bnObraComodo.PositionItem = this.bindingNavigatorPositionItem1;
            this.bnObraComodo.Size = new System.Drawing.Size(631, 25);
            this.bnObraComodo.TabIndex = 22;
            this.bnObraComodo.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cobComodosBindingSource
            // 
            this.cobComodosBindingSource.DataMember = "cobComodos";
            this.cobComodosBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobComodosTableAdapter
            // 
            this.cobComodosTableAdapter.ClearBeforeFill = true;
            // 
            // cobObraComodoTableAdapter
            // 
            this.cobObraComodoTableAdapter.ClearBeforeFill = true;
            // 
            // fKcobObrascobObraComodoBindingSource
            // 
            this.fKcobObrascobObraComodoBindingSource.DataMember = "FK_cobObras_cobObraComodo";
            this.fKcobObrascobObraComodoBindingSource.DataSource = this.cobObrasBindingSource;
            // 
            // cdObraDataGridViewTextBoxColumn1
            // 
            this.cdObraDataGridViewTextBoxColumn1.DataPropertyName = "cdObra";
            this.cdObraDataGridViewTextBoxColumn1.HeaderText = "cdObra";
            this.cdObraDataGridViewTextBoxColumn1.Name = "cdObraDataGridViewTextBoxColumn1";
            this.cdObraDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cdComodoDataGridViewTextBoxColumn
            // 
            this.cdComodoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdComodoDataGridViewTextBoxColumn.DataPropertyName = "cdComodo";
            this.cdComodoDataGridViewTextBoxColumn.DataSource = this.cobComodosBindingSource;
            this.cdComodoDataGridViewTextBoxColumn.DisplayMember = "nmComodo";
            this.cdComodoDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdComodoDataGridViewTextBoxColumn.HeaderText = "Cômodo";
            this.cdComodoDataGridViewTextBoxColumn.Name = "cdComodoDataGridViewTextBoxColumn";
            this.cdComodoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdComodoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cdComodoDataGridViewTextBoxColumn.ValueMember = "cdComodo";
            // 
            // nAreaDataGridViewTextBoxColumn
            // 
            this.nAreaDataGridViewTextBoxColumn.DataPropertyName = "nArea";
            this.nAreaDataGridViewTextBoxColumn.HeaderText = "Área";
            this.nAreaDataGridViewTextBoxColumn.Name = "nAreaDataGridViewTextBoxColumn";
            this.nAreaDataGridViewTextBoxColumn.Width = 90;
            // 
            // nMetroLinearDataGridViewTextBoxColumn
            // 
            this.nMetroLinearDataGridViewTextBoxColumn.DataPropertyName = "nMetroLinear";
            this.nMetroLinearDataGridViewTextBoxColumn.HeaderText = "Metro Linear";
            this.nMetroLinearDataGridViewTextBoxColumn.Name = "nMetroLinearDataGridViewTextBoxColumn";
            this.nMetroLinearDataGridViewTextBoxColumn.Width = 90;
            // 
            // nVolumeTetoDataGridViewTextBoxColumn
            // 
            this.nVolumeTetoDataGridViewTextBoxColumn.DataPropertyName = "nVolumeTeto";
            this.nVolumeTetoDataGridViewTextBoxColumn.HeaderText = "Vol. Teto";
            this.nVolumeTetoDataGridViewTextBoxColumn.Name = "nVolumeTetoDataGridViewTextBoxColumn";
            this.nVolumeTetoDataGridViewTextBoxColumn.Width = 90;
            // 
            // nVolumePisoDataGridViewTextBoxColumn
            // 
            this.nVolumePisoDataGridViewTextBoxColumn.DataPropertyName = "nVolumePiso";
            this.nVolumePisoDataGridViewTextBoxColumn.HeaderText = "Vol. Piso";
            this.nVolumePisoDataGridViewTextBoxColumn.Name = "nVolumePisoDataGridViewTextBoxColumn";
            this.nVolumePisoDataGridViewTextBoxColumn.Width = 90;
            // 
            // frmCadObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(645, 456);
            this.Name = "frmCadObras";
            this.Text = "Obras";
            this.Load += new System.EventHandler(this.frmCadObras_Load);
            this.tcCadastro.ResumeLayout(false);
            this.tpTabela.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobObrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObraComodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobObraComodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnObraComodo)).EndInit();
            this.bnObraComodo.ResumeLayout(false);
            this.bnObraComodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobComodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKcobObrascobObraComodoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private System.Windows.Forms.BindingSource cobObrasBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobObrasTableAdapter cobObrasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deEnderecoObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmClienteObraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnControle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNmCliente;
        private System.Windows.Forms.TextBox txtDeEndereco;
        private System.Windows.Forms.TextBox txtDeObra;
        private System.Windows.Forms.TextBox txtNmObra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvObraComodo;
        private System.Windows.Forms.BindingNavigator bnObraComodo;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource cobComodosBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobComodosTableAdapter cobComodosTableAdapter;
        private System.Windows.Forms.BindingSource cobObraComodoBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobObraComodoTableAdapter cobObraComodoTableAdapter;
        private System.Windows.Forms.BindingSource fKcobObrascobObraComodoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdObraDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cdComodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMetroLinearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVolumeTetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVolumePisoDataGridViewTextBoxColumn;
    }
}
