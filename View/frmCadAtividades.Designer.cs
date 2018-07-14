namespace cobOpus.View
{
    partial class frmCadAtividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAtividades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cobProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobDataBase_dbDataSet = new cobOpus.cobDataBase_dbDataSet();
            this.cobAtividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobAtividadesTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobAtividadesTableAdapter();
            this.cobProdutosSugeridosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobProdutosSugeridosTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobProdutosSugeridosTableAdapter();
            this.cobProdutosTableAdapter = new cobOpus.cobDataBase_dbDataSetTableAdapters.cobProdutosTableAdapter();
            this.tcCadastro = new System.Windows.Forms.TabControl();
            this.tpTabela = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cdAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deResumoAtividadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlAtividadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpFormulario = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVlAtividade = new System.Windows.Forms.TextBox();
            this.txtDeResumoAtividade = new System.Windows.Forms.TextBox();
            this.txtDeDetalheAtividade = new System.Windows.Forms.TextBox();
            this.cobAtividadescobProdutosSugeridosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnProdutosSugeridos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.dgvProdutosSugeridos = new System.Windows.Forms.DataGridView();
            this.cdProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cdAtividadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cobProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobAtividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobProdutosSugeridosBindingSource)).BeginInit();
            this.tcCadastro.SuspendLayout();
            this.tpTabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cobAtividadescobProdutosSugeridosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnProdutosSugeridos)).BeginInit();
            this.bnProdutosSugeridos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSugeridos)).BeginInit();
            this.SuspendLayout();
            // 
            // cobProdutosBindingSource
            // 
            this.cobProdutosBindingSource.DataMember = "cobProdutos";
            this.cobProdutosBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobDataBase_dbDataSet
            // 
            this.cobDataBase_dbDataSet.DataSetName = "cobDataBase_dbDataSet";
            this.cobDataBase_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobAtividadesBindingSource
            // 
            this.cobAtividadesBindingSource.DataMember = "cobAtividades";
            this.cobAtividadesBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobAtividadesTableAdapter
            // 
            this.cobAtividadesTableAdapter.ClearBeforeFill = true;
            // 
            // cobProdutosSugeridosBindingSource
            // 
            this.cobProdutosSugeridosBindingSource.DataMember = "cobProdutosSugeridos";
            this.cobProdutosSugeridosBindingSource.DataSource = this.cobDataBase_dbDataSet;
            // 
            // cobProdutosSugeridosTableAdapter
            // 
            this.cobProdutosSugeridosTableAdapter.ClearBeforeFill = true;
            // 
            // cobProdutosTableAdapter
            // 
            this.cobProdutosTableAdapter.ClearBeforeFill = true;
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
            this.tcCadastro.TabIndex = 15;
            // 
            // tpTabela
            // 
            this.tpTabela.Controls.Add(this.dgvDados);
            this.tpTabela.Location = new System.Drawing.Point(4, 22);
            this.tpTabela.Name = "tpTabela";
            this.tpTabela.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabela.Size = new System.Drawing.Size(503, 358);
            this.tpTabela.TabIndex = 0;
            this.tpTabela.Text = "Tabela";
            this.tpTabela.UseVisualStyleBackColor = true;
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
            this.cdAtividadeDataGridViewTextBoxColumn,
            this.deResumoAtividadesDataGridViewTextBoxColumn,
            this.vlAtividadeDataGridViewTextBoxColumn});
            this.dgvDados.DataSource = this.cobAtividadesBindingSource;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(497, 352);
            this.dgvDados.TabIndex = 15;
            // 
            // cdAtividadeDataGridViewTextBoxColumn
            // 
            this.cdAtividadeDataGridViewTextBoxColumn.DataPropertyName = "cdAtividade";
            this.cdAtividadeDataGridViewTextBoxColumn.HeaderText = "cdAtividade";
            this.cdAtividadeDataGridViewTextBoxColumn.Name = "cdAtividadeDataGridViewTextBoxColumn";
            this.cdAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdAtividadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // deResumoAtividadesDataGridViewTextBoxColumn
            // 
            this.deResumoAtividadesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deResumoAtividadesDataGridViewTextBoxColumn.DataPropertyName = "deResumoAtividades";
            this.deResumoAtividadesDataGridViewTextBoxColumn.HeaderText = "Resumo";
            this.deResumoAtividadesDataGridViewTextBoxColumn.Name = "deResumoAtividadesDataGridViewTextBoxColumn";
            this.deResumoAtividadesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlAtividadeDataGridViewTextBoxColumn
            // 
            this.vlAtividadeDataGridViewTextBoxColumn.DataPropertyName = "vlAtividade";
            dataGridViewCellStyle2.Format = "C2";
            this.vlAtividadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.vlAtividadeDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.vlAtividadeDataGridViewTextBoxColumn.Name = "vlAtividadeDataGridViewTextBoxColumn";
            this.vlAtividadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tpFormulario
            // 
            this.tpFormulario.Controls.Add(this.splitContainer1);
            this.tpFormulario.Location = new System.Drawing.Point(4, 22);
            this.tpFormulario.Name = "tpFormulario";
            this.tpFormulario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulario.Size = new System.Drawing.Size(503, 358);
            this.tpFormulario.TabIndex = 1;
            this.tpFormulario.Text = "Fromulário";
            this.tpFormulario.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtVlAtividade);
            this.splitContainer1.Panel1.Controls.Add(this.txtDeResumoAtividade);
            this.splitContainer1.Panel1.Controls.Add(this.txtDeDetalheAtividade);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProdutosSugeridos);
            this.splitContainer1.Panel2.Controls.Add(this.bnProdutosSugeridos);
            this.splitContainer1.Size = new System.Drawing.Size(497, 352);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Detalhamento da atividade";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resumo da atividade";
            // 
            // txtVlAtividade
            // 
            this.txtVlAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVlAtividade.Location = new System.Drawing.Point(392, 24);
            this.txtVlAtividade.Name = "txtVlAtividade";
            this.txtVlAtividade.Size = new System.Drawing.Size(104, 20);
            this.txtVlAtividade.TabIndex = 8;
            // 
            // txtDeResumoAtividade
            // 
            this.txtDeResumoAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeResumoAtividade.Location = new System.Drawing.Point(5, 24);
            this.txtDeResumoAtividade.Name = "txtDeResumoAtividade";
            this.txtDeResumoAtividade.Size = new System.Drawing.Size(381, 20);
            this.txtDeResumoAtividade.TabIndex = 7;
            // 
            // txtDeDetalheAtividade
            // 
            this.txtDeDetalheAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeDetalheAtividade.Location = new System.Drawing.Point(5, 63);
            this.txtDeDetalheAtividade.Multiline = true;
            this.txtDeDetalheAtividade.Name = "txtDeDetalheAtividade";
            this.txtDeDetalheAtividade.Size = new System.Drawing.Size(487, 96);
            this.txtDeDetalheAtividade.TabIndex = 6;
            // 
            // cobAtividadescobProdutosSugeridosBindingSource
            // 
            this.cobAtividadescobProdutosSugeridosBindingSource.DataMember = "cobAtividades_cobProdutosSugeridos";
            this.cobAtividadescobProdutosSugeridosBindingSource.DataSource = this.cobAtividadesBindingSource;
            // 
            // bnProdutosSugeridos
            // 
            this.bnProdutosSugeridos.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bnProdutosSugeridos.BindingSource = this.cobAtividadescobProdutosSugeridosBindingSource;
            this.bnProdutosSugeridos.CountItem = this.bindingNavigatorCountItem1;
            this.bnProdutosSugeridos.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bnProdutosSugeridos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnProdutosSugeridos.Location = new System.Drawing.Point(0, 0);
            this.bnProdutosSugeridos.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bnProdutosSugeridos.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bnProdutosSugeridos.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bnProdutosSugeridos.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bnProdutosSugeridos.Name = "bnProdutosSugeridos";
            this.bnProdutosSugeridos.PositionItem = this.bindingNavigatorPositionItem1;
            this.bnProdutosSugeridos.Size = new System.Drawing.Size(497, 25);
            this.bnProdutosSugeridos.TabIndex = 20;
            this.bnProdutosSugeridos.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
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
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Excluir";
            // 
            // dgvProdutosSugeridos
            // 
            this.dgvProdutosSugeridos.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvProdutosSugeridos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutosSugeridos.AutoGenerateColumns = false;
            this.dgvProdutosSugeridos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvProdutosSugeridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSugeridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdProdutoDataGridViewTextBoxColumn,
            this.cdAtividadeDataGridViewTextBoxColumn1});
            this.dgvProdutosSugeridos.DataSource = this.cobAtividadescobProdutosSugeridosBindingSource;
            this.dgvProdutosSugeridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosSugeridos.Location = new System.Drawing.Point(0, 25);
            this.dgvProdutosSugeridos.Name = "dgvProdutosSugeridos";
            this.dgvProdutosSugeridos.Size = new System.Drawing.Size(497, 154);
            this.dgvProdutosSugeridos.TabIndex = 21;
            // 
            // cdProdutoDataGridViewTextBoxColumn
            // 
            this.cdProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdProdutoDataGridViewTextBoxColumn.DataPropertyName = "cdProduto";
            this.cdProdutoDataGridViewTextBoxColumn.DataSource = this.cobProdutosBindingSource;
            this.cdProdutoDataGridViewTextBoxColumn.DisplayMember = "nmProduto";
            this.cdProdutoDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdProdutoDataGridViewTextBoxColumn.HeaderText = "Produto sugerido";
            this.cdProdutoDataGridViewTextBoxColumn.Name = "cdProdutoDataGridViewTextBoxColumn";
            this.cdProdutoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cdProdutoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cdProdutoDataGridViewTextBoxColumn.ValueMember = "cdProduto";
            // 
            // cdAtividadeDataGridViewTextBoxColumn1
            // 
            this.cdAtividadeDataGridViewTextBoxColumn1.DataPropertyName = "cdAtividade";
            this.cdAtividadeDataGridViewTextBoxColumn1.HeaderText = "cdAtividade";
            this.cdAtividadeDataGridViewTextBoxColumn1.Name = "cdAtividadeDataGridViewTextBoxColumn1";
            this.cdAtividadeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // frmCadAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(511, 409);
            this.Controls.Add(this.tcCadastro);
            this.Name = "frmCadAtividades";
            this.Text = "Atividades";
            this.Load += new System.EventHandler(this.frmCadAtividades_Load);
            this.Controls.SetChildIndex(this.tcCadastro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cobProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobDataBase_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobAtividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobProdutosSugeridosBindingSource)).EndInit();
            this.tcCadastro.ResumeLayout(false);
            this.tpTabela.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tpFormulario.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cobAtividadescobProdutosSugeridosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnProdutosSugeridos)).EndInit();
            this.bnProdutosSugeridos.ResumeLayout(false);
            this.bnProdutosSugeridos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSugeridos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private cobDataBase_dbDataSet cobDataBase_dbDataSet;
        private System.Windows.Forms.BindingSource cobAtividadesBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobAtividadesTableAdapter cobAtividadesTableAdapter;
        private System.Windows.Forms.BindingSource cobProdutosBindingSource;
        private cobDataBase_dbDataSetTableAdapters.cobProdutosTableAdapter cobProdutosTableAdapter;
        private System.Windows.Forms.TabControl tcCadastro;
        private System.Windows.Forms.TabPage tpTabela;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deResumoAtividadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlAtividadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tpFormulario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVlAtividade;
        private System.Windows.Forms.TextBox txtDeResumoAtividade;
        private System.Windows.Forms.TextBox txtDeDetalheAtividade;
        private cobDataBase_dbDataSetTableAdapters.cobProdutosSugeridosTableAdapter cobProdutosSugeridosTableAdapter;
        private System.Windows.Forms.BindingSource cobProdutosSugeridosBindingSource;
        private System.Windows.Forms.BindingNavigator bnProdutosSugeridos;
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
        private System.Windows.Forms.BindingSource cobAtividadescobProdutosSugeridosBindingSource;
        private System.Windows.Forms.DataGridView dgvProdutosSugeridos;
        private System.Windows.Forms.DataGridViewComboBoxColumn cdProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAtividadeDataGridViewTextBoxColumn1;
    }
}
