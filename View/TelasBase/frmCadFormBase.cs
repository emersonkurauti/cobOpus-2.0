using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cobOpus.View
{
    public partial class frmCadFormBase : cobOpus.View.frmCadGridBase
    {
        public frmCadFormBase()
        {
            InitializeComponent();
        }

        protected override void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            base.bindingNavigatorAddNewItem_Click(sender, e);
            tcCadastro.SelectedTab = tpFormulario;
        }
    }
}
