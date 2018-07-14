using System;
using System.Data;

namespace cobOpus.View
{
    public partial class frmCadAtividades : cobOpus.View.frmCadGridBase
    {
        public frmCadAtividades()
        {
            InitializeComponent();
            base.AplicarEventosMascaraMoeda(txtVlAtividade);
        }

        private void frmCadAtividades_Load(object sender, EventArgs e)
        {
            this.cobProdutosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutos);
            this.cobAtividadesTableAdapter.Fill(this.cobDataBase_dbDataSet.cobAtividades);
            this.cobProdutosSugeridosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutosSugeridos);
            this.bnControle.BindingSource = cobAtividadesBindingSource;
            
            txtDeResumoAtividade.DataBindings.Add("Text", cobAtividadesBindingSource, "deResumoAtividades", true);
            txtDeDetalheAtividade.DataBindings.Add("Text", cobAtividadesBindingSource, "deAtividadeDetalhado", true);
            txtVlAtividade.DataBindings.Add("Text", cobAtividadesBindingSource, "vlAtividade", true);

            dgvProdutosSugeridos.Columns["cdAtividade"].Visible = false;
        }

        protected override void tsbSalvar_Click(object sender, EventArgs e)
        {
            base.tsbSalvar_Click(sender, e);
            if (!bRegistroValido)
            {
                return;
            }

            cobAtividadesBindingSource.EndEdit();
            cobProdutosSugeridosBindingSource.EndEdit();

            cobAtividadesTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            cobProdutosSugeridosTableAdapter.Adapter.Update(cobDataBase_dbDataSet);

            tsbRestaurar_Click(null, null);
        }

        protected override void tsbRestaurar_Click(object sender, EventArgs e)
        {
            this.cobProdutosSugeridosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutosSugeridos);
            this.cobAtividadesTableAdapter.Fill(this.cobDataBase_dbDataSet.cobAtividades);
            this.cobProdutosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutos);
            base.tsbRestaurar_Click(sender, e);
        }
    }
}
