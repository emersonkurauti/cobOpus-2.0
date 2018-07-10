using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobOpus.View.TelasBase
{
    public partial class frmCadGridBase : Form
    {
        public frmCadGridBase()
        {
            InitializeComponent();
        }

        protected virtual void tsbSalvar_Click(object sender, EventArgs e)
        {
            Validate();
        }

        protected virtual void tsbRestaurar_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }
    }
}
