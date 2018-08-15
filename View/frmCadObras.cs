using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cobOpus.View
{
    public partial class frmCadObras : cobOpus.View.frmCadFormBase
    {
        public frmCadObras()
        {
            InitializeComponent();
        }

        private void frmCadObras_Load(object sender, EventArgs e)
        {
            this.cobComodosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobComodos);
            this.cobObraComodoTableAdapter.Fill(this.cobDataBase_dbDataSet.cobObraComodo);
            this.cobObrasTableAdapter.Fill(this.cobDataBase_dbDataSet.cobObras);
            this.bnControle.BindingSource = cobObrasBindingSource;

            txtNmObra.DataBindings.Add("Text", cobObrasBindingSource, "nmObra", true);
            txtDeObra.DataBindings.Add("Text", cobObrasBindingSource, "deObra", true);
            txtDeEndereco.DataBindings.Add("Text", cobObrasBindingSource, "deEnderecoObra", true);
            txtNmCliente.DataBindings.Add("Text", cobObrasBindingSource, "nmClienteObra", true);

            dgvObraComodo.Columns["cdObra"].Visible = false;
        }

        protected override void tsbSalvar_Click(object sender, EventArgs e)
        {
            base.tsbSalvar_Click(sender, e);
            if (!bRegistroValido)
            {
                return;
            }

            cobObrasBindingSource.EndEdit();
            cobObraComodoBindingSource.EndEdit();

            cobObrasTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            cobObraComodoTableAdapter.Adapter.Update(cobDataBase_dbDataSet);
            
            tsbRestaurar_Click(null, null);
        }

        protected override void tsbRestaurar_Click(object sender, EventArgs e)
        {
            this.cobDataBase_dbDataSet.cobObraComodo.Clear();
            this.cobDataBase_dbDataSet.cobComodos.Clear();
            this.cobDataBase_dbDataSet.cobObras.Clear();

            this.cobObrasTableAdapter.Fill(this.cobDataBase_dbDataSet.cobObras);
            this.cobComodosTableAdapter.Fill(this.cobDataBase_dbDataSet.cobComodos);
            this.cobObraComodoTableAdapter.Fill(this.cobDataBase_dbDataSet.cobObraComodo);
            base.tsbRestaurar_Click(sender, e);
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nCdObra = 0;
            if (e.ColumnIndex == this.btnControle.Index && e.RowIndex >= 0)
            {
                DataGridViewRow currentRow = this.dgvDados.Rows[e.RowIndex];
                nCdObra = Convert.ToInt32(currentRow.Cells[0].Value);
            }
        }
    }
}
