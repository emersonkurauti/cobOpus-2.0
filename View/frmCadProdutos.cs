using System;
using System.Windows.Forms;

namespace cobOpus.View
{
    public partial class frmCadProdutos : frmCadGridBase
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void frmCadProdutos_Load(object sender, EventArgs e)
        {
            this.cobUnidadeMedidaTableAdapter.Fill(this.cobDataBase_dbDataSet.cobUnidadeMedida);
            this.cobProdutosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutos);
            this.bnControle.BindingSource = cobProdutosBindingSource;
        }

        protected override void tsbSalvar_Click(object sender, EventArgs e)
        {
            base.tsbSalvar_Click(sender, e);
            cobProdutosBindingSource.EndEdit();
            cobProdutosTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            tsbRestaurar_Click(null, null);
        }

        protected override void tsbRestaurar_Click(object sender, EventArgs e)
        {
            this.cobProdutosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutos);
            base.tsbRestaurar_Click(sender, e);
        }
    }
}
