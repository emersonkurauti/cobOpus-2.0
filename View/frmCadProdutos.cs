using System;
using System.Drawing;
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
            if (!bRegistroValido)
            {
                return;
            }
            cobProdutosBindingSource.EndEdit();
            cobProdutosTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            tsbRestaurar_Click(null, null);
        }

        protected override void tsbRestaurar_Click(object sender, EventArgs e)
        {
            this.cobProdutosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobProdutos);
            base.tsbRestaurar_Click(sender, e);
        }

        private void dgvDados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string sNomeColuna = dgvDados.Columns[e.ColumnIndex].DataPropertyName;
            string sDeCampo = dgvDados.Columns[e.ColumnIndex].HeaderText;

            if (!cobDataBase_dbDataSet.cobProdutos.Columns[sNomeColuna].AllowDBNull &&
                string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                bRegistroValido = false;
                tslMensagem.Visible = true;
                tslMensagem.Text = sDeCampo + " é obrigatório.";
                tslMensagem.ForeColor = Color.Red;
                e.Cancel = true;
                return;
            }
            bRegistroValido = true;
            tslMensagem.Visible = false;
        }

        private void dgvDados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bRegistroValido = true;
            tslMensagem.Visible = false;
        }
    }
}
