using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace cobOpus
{
    public partial class frmMenu : cobOpus.frmMenuBasico
    {
        private ArrayList alIntSeqTelas = new ArrayList();
        private ArrayList alTelas = new ArrayList();

        /// <summary>
        /// Construtor do menu
        /// </summary>
        public frmMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega items de menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            ItemMenuStrip();
            ItemToolStrip();
        }

        /// <summary>
        /// Adiciona o nome do formulário na lista para pesquisa rápida
        /// </summary>
        /// <param name="nmTipoForm"></param>
        public void AddListTela(string nmTipoForm)
        {
            Type tipo;
            Form form;

            tipo = Type.GetType(nmTipoForm);

            form = (Form)Activator.CreateInstance(tipo);
            alTelas.Add(form.Text);
        }

        /// <summary>
        /// Adiciona items de menu
        /// </summary>
        public override void ItemMenuStrip()
        {
            AddListTela("cobOpus.View.frmCadComodos");
            AddListTela("cobOpus.View.frmCadProdutos");
            AddListTela("cobOpus.View.frmCadAtividades");
            AddListTela("cobOpus.View.frmCadUnidadeMedida");
            AddListTela("cobOpus.View.frmCadObras");

            ToolStripMenuItem menuCadastros = RetornarItemMenuCriado(menuStrip, "&Cadastros", null, null, "btnCadastros");
            CriarSubItemMenu(menuCadastros, "&Atividades...", null, ItemMenu_onClick, "cobOpus.View.frmCadAtividades");
            CriarSubItemMenu(menuCadastros, "&Cômodos...", null, ItemMenu_onClick, "cobOpus.View.frmCadComodos");
            CriarSubItemMenu(menuCadastros, "&Obras...", null, ItemMenu_onClick, "cobOpus.View.frmCadObras");
            CriarSubItemMenu(menuCadastros, "&Produtos...", null, ItemMenu_onClick, "cobOpus.View.frmCadProdutos");
            CriarSubItemMenu(menuCadastros, "&Unidades de medida...", null, ItemMenu_onClick, "cobOpus.View.frmCadUnidadeMedida");

            AddItemMenu(menuStrip, "&Sair", null, btnSair_onClick, "btnSair");
        }

        /// <summary>
        /// Método para abrir as as telas do menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ItemMenu_onClick(object sender, EventArgs e)
        {
            Type tipo = Type.GetType(((ToolStripMenuItem)sender).Name);

            if (!VerificaTelaAberta(((ToolStripMenuItem)sender).Name))
            {
                Form form = (Form)Activator.CreateInstance(tipo);

                for (int i = 0; i < menuTelas.Items.Count; i++)
                    menuTelas.Items[i].BackColor = Color.LightGray;

                AtualizaIndiceTelas();
                alIntSeqTelas.Add(0);

                ToolStripMenuItem ItemMenuTela = RetornarItemMenuCriado(menuTelas, form.Text, null, ItemMenuTela_onClick, ((ToolStripMenuItem)sender).Name);
                ItemMenuTela.BackColor = Color.White;

                form.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                form.MdiParent = this;
                form.Show();
            }
        }

        /// <summary>
        /// Verifica se a tela está aberta
        /// </summary>
        /// <param name="nmTela"></param>
        /// <returns></returns>
        public bool VerificaTelaAberta(string nmTela)
        {
            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if (menuTelas.Items[i].Name.Equals(nmTela))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Atualiza os indices da sequência de abertura das telas
        /// </summary>
        /// <param name="bAdd"></param>
        private void AtualizaIndiceTelas(bool bAdd = true)
        {
            if (bAdd)
                for (int i = 0; i < alIntSeqTelas.Count; i++)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) + 1).ToString();
            else
                for (int i = 0; i < alIntSeqTelas.Count; i++)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) - 1).ToString();
        }

        /// <summary>
        /// Remaneja os indices para que mantenha a sequência de abertura das telas atualizado
        /// </summary>
        /// <param name="nmTela"></param>
        public void RemanejaIndiceTela(string nmTela)
        {
            int IndAnterior = 0, pos0 = 0;

            for (int i = 0; i < menuTelas.Items.Count; i++)
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("cobOpus.View.", "").Equals(nmTela))
                {
                    IndAnterior = Convert.ToInt32(alIntSeqTelas[i].ToString());
                    pos0 = i;
                }

            for (int i = 0; i < alIntSeqTelas.Count; i++)
                if (Convert.ToInt32(alIntSeqTelas[i].ToString()) < IndAnterior)
                    alIntSeqTelas[i] = (Convert.ToInt32(alIntSeqTelas[i].ToString()) + 1).ToString();

            alIntSeqTelas[pos0] = 0;
        }

        /// <summary>
        /// Evento de fechar um MdiChild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            AtualizaIndiceTelas(false);

            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("cobOpus.View.", "").Equals(((Form)sender).Name))
                {
                    menuTelas.Items.RemoveAt(i);
                    alIntSeqTelas.RemoveAt(i);
                }
            }

            for (int i = 0; i < alIntSeqTelas.Count; i++)
                if (Convert.ToInt32(alIntSeqTelas[i].ToString()) == 0)
                    menuTelas.Items[i].BackColor = Color.White;
        }

        /// <summary>
        /// Evento disparado ao clicar em um menu de tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemMenuTela_onClick(object sender, EventArgs e)
        {
            Type tipo = Type.GetType(((ToolStripMenuItem)sender).Name);

            Form[] formMDI = MdiChildren;

            foreach (Form frm in formMDI)
                if (frm.Name.Equals(tipo.Name))
                    frm.Activate();

            for (int i = 0; i < menuTelas.Items.Count; i++)
            {
                if ((menuTelas.Items[i].Name).Replace("appRelatorios.", "").Replace(",appRelatorios", "").Replace("cobOpus.View.", "").Equals(tipo.Name))
                    menuTelas.Items[i].BackColor = Color.White;
                else
                    menuTelas.Items[i].BackColor = Color.LightGray;
            }

            RemanejaIndiceTela(tipo.Name);
        }
    }
}
