using System;
using System.Windows.Forms;
using cobOpus.View;

namespace cobOpus
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsmiComodos_Click(object sender, EventArgs e)
        {
            frmCadComodos frmCadComodos = new frmCadComodos();
            frmCadComodos.MdiParent = this;
            frmCadComodos.Show();
        }
    }
}