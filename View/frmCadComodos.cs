using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cobOpus.View
{
    public partial class frmCadComodos : cobOpus.View.TelasBase.frmCadGridBase
    {
        public frmCadComodos()
        {
            InitializeComponent();
        }

        private void frmCadComodos_Load(object sender, EventArgs e)
        {
            this.cobComodosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobComodos);
            this.bnControle.BindingSource = cobComodosBindingSource;
        }

        protected override void tsbSalvar_Click(object sender, EventArgs e)
        {
            base.tsbSalvar_Click(sender, e);
            cobComodosBindingSource.EndEdit();
            cobComodosTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            tsbRestaurar_Click(null, null);
        }

        protected override void tsbRestaurar_Click(object sender, EventArgs e)
        {
            this.cobComodosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobComodos);
            base.tsbRestaurar_Click(sender, e);
        }

        private void dgvDados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dgvDados.CancelEdit();
                cobComodosBindingSource.CancelEdit();
                bindingNavigatorAddNewItem.Enabled = true;
            }
        }
    }
}
