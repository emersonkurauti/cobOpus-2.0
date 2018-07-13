using System;
using System.Windows.Forms;

namespace cobOpus.View
{
    public partial class frmCadGridBase : Form
    {
        protected bool bRegistroValido;

        public frmCadGridBase()
        {
            InitializeComponent();
            bRegistroValido = true;
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
