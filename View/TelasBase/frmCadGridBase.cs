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

        protected virtual void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(txt.Text).ToString("C2");
        }

        private void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }

        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(","));
                }
                else
                    e.Handled = true;
            }
        }

        protected void AplicarEventosMascaraMoeda(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }
    }
}
