using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cobOpus.View
{
	public partial class frmCadUnidadeMedida : cobOpus.View.frmCadGridBase
	{
		public frmCadUnidadeMedida()
		{
			InitializeComponent();
		}

        private void frmCadUnidadeMedida_Load(object sender, EventArgs e)
        {
            this.cobUnidadeMedidaTableAdapter.Fill(this.cobDataBase_dbDataSet.cobUnidadeMedida);
            this.bnControle.BindingSource = cobUnidadeMedidaBindingSource;
        }

        protected override void tsbSalvar_Click(object sender, EventArgs e)
        {
            base.tsbSalvar_Click(sender, e);
            cobUnidadeMedidaBindingSource.EndEdit();
            cobUnidadeMedidaTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            tsbRestaurar_Click(null, null);
        }

        protected override void tsbRestaurar_Click(object sender, EventArgs e)
        {
            this.cobUnidadeMedidaTableAdapter.Fill(this.cobDataBase_dbDataSet.cobUnidadeMedida);
            base.tsbRestaurar_Click(sender, e);
        }

        private void dgvDados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvDados.CancelEdit();
                cobUnidadeMedidaBindingSource.CancelEdit();
                bindingNavigatorAddNewItem.Enabled = true;
            }
        }
    }
}
