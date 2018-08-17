using cobOpus.View.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobOpus.View
{
    public partial class frmPainelObras : Form
    {
        public frmPainelObras()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmPainelObras_Load(object sender, EventArgs e)
        {
            CarregarObras();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            flpPainel.Controls.Clear();
            CarregarObras();
        }

        private void CarregarObras()
        {
            DataTable dtObras = new DataTable();
            this.cobObrasTableAdapter.Fill(this.cobDataBase_dbDataSet.cobObras);
            dtObras = this.cobObrasTableAdapter.GetData();

            foreach (DataRow dr in dtObras.Rows)
            {
                ucCardObra oucCardObra = new ucCardObra(Convert.ToInt32(dr["cdObra"].ToString()));
                flpPainel.Controls.Add(oucCardObra);
            }
        }

        private void btnNovaObra_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmControle = new ToolStripMenuItem("CadObra", null, null, "cobOpus.View.frmCadObras");
            ((frmMenu)this.Parent.Parent).ItemMenu_onClick(tsmControle, null);
        }
    }
}
