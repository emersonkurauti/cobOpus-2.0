using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace CustomSkoProgressBar
{
    public partial class SkoProgressBar : UserControl
    {
        public SkoProgressBar()
        {
            InitializeComponent();
        }

#region ----------Variaveis----------

        Graphics gra;
        protected int Val = 0;
        protected Color CorBarra = Color.CornflowerBlue;
        protected Color CorValor = Color.Black;
        protected LinearGradientMode GradMode = LinearGradientMode.Vertical;

        public enum Modos { Normal, Velôcimetro }
        Modos Modo;

#endregion


#region ----------Propriedades----------

        public Modos Modes
        {
            get{ return Modo;}
            set
            {
                Modo = value;
                if (value.ToString() != "Normal") { LblValor.Visible = false; }
                else { LblValor.Visible = true; }
            }
        }

        public Color Cor_da_Barra
        {
            get { return CorBarra; }
            set { CorBarra = value; }
        }

        public Color Cor_do_Valor
        {
            get { return CorValor; }
            set 
            {
                CorValor = value; 
                LblValor.ForeColor = value;
            }
        }

        public LinearGradientMode GradientMode
        {
            get { return GradMode; }
            set { GradMode = value; }
        } 

        public int Valor
        {
            get { return Val; }
            set
            {
                if (value <= 100 && value >= 0) { Val = value; }
                if (Modo.ToString() == "Normal") { LblValor.Text = Val.ToString(); }
                this.Refresh();
            }
        }

        #endregion


        #region ----------Voids----------

        protected override void OnPaint(PaintEventArgs e)
        {

            gra = this.CreateGraphics();
            gra.SmoothingMode = SmoothingMode.HighQuality;
            int Porcentagem = Val * 3 + 180;

            float Tamanho = this.Height / 4;
            double Angulo = Porcentagem * Math.PI / 180;

            gra.DrawLine(new Pen(Color.Black, 2),
            this.ClientSize.Width / 2,
            this.ClientSize.Height / 2,
            this.ClientSize.Width / 2 + (float)(Tamanho * System.Math.Sin(Angulo)),
            this.ClientSize.Height / 2 - (float)(Tamanho * System.Math.Cos(Angulo)));

            Design();
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, this.BackColor, 0,
                ButtonBorderStyle.Solid, this.BackColor, 0, ButtonBorderStyle.Solid,
                this.BackColor, 0, ButtonBorderStyle.Solid, this.BackColor, 0,
                ButtonBorderStyle.Solid);
        }

        private void Design()
        {
            float Raio = this.Height / 2;
            float CentroX = this.ClientSize.Width / 2;
            float CentroY = this.ClientSize.Height / 2;

            int Num = 0;
            for (int Cont = 30; Cont <= 80; Cont++)
            {
                if (Cont % 5 == 0)
                {
                    gra.DrawLine(new Pen(Color.Black, 2),
                    CentroX + (float)(Raio / 1.50F * System.Math.Sin(Cont * 6 * Math.PI / 180)),
                    CentroY - (float)(Raio / 1.50F * System.Math.Cos(Cont * 6 * Math.PI / 180)),
                    CentroX + (float)(Raio / 1.70F * System.Math.Sin(Cont * 6 * Math.PI / 180)),
                    CentroY - (float)(Raio / 1.70F * System.Math.Cos(Cont * 6 * Math.PI / 180)));

                    gra.DrawString((Num).ToString(), new Font("Palatino Linotype", 9), new SolidBrush(Color.Black),
                    (CentroX - 10) + (float)((Raio + 15) / 1.50F * System.Math.Sin(Cont * 6 * Math.PI / 180)),
                    (CentroY - 10) - (float)((Raio + 15) / 1.50F * System.Math.Cos(Cont * 6 * Math.PI / 180)));

                    Num += 10;
                }
                else
                {
                    gra.DrawLine(new Pen(Color.Red, 2),
                    CentroX + (float)(Raio / 1.50F * System.Math.Sin(Cont * 6 * Math.PI / 180)),
                    CentroY - (float)(Raio / 1.50F * System.Math.Cos(Cont * 6 * Math.PI / 180)),
                    CentroX + (float)(Raio / 1.60F * System.Math.Sin(Cont * 6 * Math.PI / 180)),
                    CentroY - (float)(Raio / 1.60F * System.Math.Cos(Cont * 6 * Math.PI / 180)));
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            LblValor.Left = this.Width / 2 - LblValor.Width / 2;
            LblValor.Top = this.Height / 2 - LblValor.Height / 2;
            base.OnSizeChanged(e);
        }

#endregion

    }
}
