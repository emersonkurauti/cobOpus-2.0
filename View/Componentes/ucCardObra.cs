using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace cobOpus.View.Componentes
{
    public partial class ucCardObra : ucCardBase
    {
        public Color BorderColor;
        public int BorderWidth;

        private int _cdObra;
        public int cdObra { get; }

        public ucCardObra(int pnCdObra)
        {
            BorderColor = Color.CadetBlue;
            BorderWidth = 1;
            InitializeComponent();
            _cdObra = pnCdObra;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, BorderColor, BorderWidth, 
                ButtonBorderStyle.Solid, BorderColor, BorderWidth, ButtonBorderStyle.Solid,
                BorderColor, BorderWidth, ButtonBorderStyle.Solid, BorderColor, BorderWidth, 
                ButtonBorderStyle.Solid);
        }

        private void ucCardObra_Load(object sender, EventArgs e)
        {
            CarregarInformacoesObra();
        }

        public void CarregarInformacoesObra()
        {
            string sql = "SELECT * FROM cobObras WHERE cdObra = @cdObra";

            SQLiteConnection conn = new SQLiteConnection(@"Data Source=|DataDirectory|\DataBase.db");
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdObra", _cdObra);
            conn.Open();
            try
            {
                SQLiteDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    lbObra.Text= leitor["nmObra"].ToString();
                    lbCliente.Text = leitor["nmClienteObra"].ToString();
                    lbEndereco.Text = leitor["deEnderecoObra"].ToString();
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void ucCardObra_MouseEnter(object sender, EventArgs e)
        {
            BorderWidth = 2;
            this.Refresh();
        }

        private void ucCardObra_MouseLeave(object sender, EventArgs e)
        {
            BorderWidth = 1;
            this.Refresh();
        }
    }
}
