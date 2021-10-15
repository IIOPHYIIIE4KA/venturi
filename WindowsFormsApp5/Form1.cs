using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
  
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void validateTextbox(TextBox _text, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    &&  e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (_text.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (_text.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(_text.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (_text.SelectionStart != _text.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = _text.Text.Substring(_text.SelectionStart);

                    if (AfterDotString.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            //check if a number pressed

            if (Char.IsDigit(e.KeyChar))
            {
                //check if a coma or dot exist
                if (alreadyExist(_text.Text, ref sepratorChar))
                {
                    int sepratorPosition = _text.Text.IndexOf(sepratorChar);
                    string afterSepratorString = _text.Text.Substring(sepratorPosition + 1);
                    if (_text.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                    {
                        e.Handled = true;
                    }

                }
            }
        }

        private void pgtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox)
            {
                validateTextbox(sender as TextBox, e);
            }
            
        }

        private void pgtextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double V0c = 0;
            Double tM = 0;
            Double i1 = 0;
            Double i2 = 0;
            Double Q = 0;
            Double dTavg = 0;
            Double Mb = 0;
            Double x2 = 0;
            Double Vg = 0;
            Double p2 = 0;
            Double k0 = 0;
            Double vc = 0;
            Double d = 0;
            Double h = 0;
            Double hd = 0;
            Double Kch = 0;
            Double Nch = 0;
            Double n = 0;
            Double iP = 0;
            Double tk = 0;
            Double i = 0;

            Double Vgg = 0;
            Double Pbar = 0;
            Double T = 0;
            Double X = 0;
            Double Wg = 0;
            Double Pb = 0;
            Double Fi = 0;
            Double P0 = 0;
            Double Pg = 0;
            try
            {
                Vgg = Convert.ToDouble(Vgtext.Text);
                Pbar = Convert.ToDouble(pBartext.Text);
                T = Convert.ToDouble(tText.Text);
                X = Convert.ToDouble(xText.Text) * 0.001;
                Pb = Convert.ToDouble(pBtext.Text);
                Fi = Convert.ToDouble(fiText.Text);
                P0 = Convert.ToDouble(dPtext.Text);
                Pg = Convert.ToDouble(pgTextt.Text);
                Wg = Convert.ToDouble(wGtext.Text);

                tM = getTemp(X * 1000, T);
                V0c = (Vgg * 0.804*274*(Pbar-Pg))/(tM*(0.804+X)*(273+T)*Pbar);
                i1 = 2480+ T*1.96;
                i2 = 2489 + tM * 1.96;
                iP = (i1 + i2) / 2;
                Q = V0c*(1.3*(T-tM)+X*(i1-i2));
                dTavg = ((T - tM - 5) - (tM - 20)) / (2.3 * Math.Log10((T - tM - 5) / (tM - 20)));
                tk = tM - 5;
                i = entropy(tk);
                Mb = Q/(Fi*(iP-i) + (1-0.5)*(230-i));
                x2 = X  + (Fi*Mb)/V0c;
                Vg = V0c*(((0.804+x2)*(273+tM)*Pbar)/(0.804*273*(Pbar+Pg)));
                p2 = ((P0+x2)*0.804*273*(Pbar+Pg))/((0.804+x2)*(273+tM)*Pbar);
                k0 = (116+525*((Mb)/(Vg*p2)))*(1+0.001*113);
                vc = Q*1000/(k0*dTavg);
                d = Math.Sqrt(Vg/(0.785*Wg));
                h = 2.5*d;
                v0Label.Text = "= " + Math.Round(V0c, 2).ToString();
                String tm = "";
                if (tM == 0)
                {
                    tm = "-";
                } else
                {
                    tm = Math.Round(tM, 2).ToString();
                }
                tmLabel.Text = "Температура мокрого термометра °С = " + tm;
                i1Label.Text = "= " + Math.Round(i1, 2).ToString();
                i2Label.Text = "= " + Math.Round(i2, 2).ToString();
                qLabel.Text = "= " + Math.Round(Q, 2).ToString();
                dTlabel.Text = "= " + Math.Round(dTavg, 2).ToString();
                mBlabel.Text = "= " + Math.Round(Mb, 2).ToString();
                x2Label.Text = "= " + Math.Round(x2, 2).ToString();
                vgLabel.Text = "= " + Math.Round(Vg, 2).ToString();
                p2Label.Text = "= " + Math.Round(p2, 2).ToString();
                k0Label.Text = "= " + Math.Round(k0, 2).ToString();
                vClabel.Text = "= " + Math.Round(vc, 2).ToString();
                dLabel.Text = "= " + Math.Round(d, 2).ToString();
                hLabel.Text = "= " + Math.Round(h, 2).ToString();
                p2Label.Text = "= " + Math.Round(p2, 2).ToString();
                vClabel.Text = "= " + Math.Round(vc, 2).ToString();
                dLabel.Text = "= " + Math.Round(d, 2).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Неверные данные, проверьте поля");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Double entropy(double t)
        {
            Double i = 0;
            if (i == 0)
            {
                i = 0;
            }
            if (i <= 10)
            {
                i = 42.04;
            }
            if (i <= 20)
            {
                i = 83.91;
            }
            if (i <= 30)
            {
                i = 125.7;
            }
            if (i <= 40)
            {
                i = 167.5;
            }
            if (i <= 50)
            {
                i = 209.3;
            }
            if (i <= 55)
            {
                i = 230;
            }
            if (i <= 60)
            {
                i = 251.1;
            }
            if (i <= 70)
            {
                i = 293; 
            }
            if (i <= 80)
            {
                i = 355;
            }
            if (i <= 90)
            {
                i = 377;
            }
            if (i <= 100)
            {
                i = 419.1;
            }
            return i;
        }

        private double getTemp(double v, double t)
        {
            double tt = 0;
            if (v >= 25)
            {
                if (t >= 100)
                {
                    tt = 38.5;
                }
                if (t >= 200)
                {
                    tt = 49.5;
                }
                if (t >= 300)
                {
                    tt = 57;
                }
                if (t >= 400)
                {
                    tt = 62;
                }
                if (t >= 500)
                {
                    tt = 65;
                }
                if (t >= 750)
                {
                    tt = 72.5;
                }
                if (t >= 1000)
                {
                    tt = 77.5;
                }
            } 
            if (v >= 50)
            {
                if (t >= 100)
                {
                    tt = 44;
                }
                if (t >= 200)
                {
                    tt = 53;
                }
                if (t >= 300)
                {
                    tt = 59.5;
                }
                if (t >= 400)
                {
                    tt = 64;
                }
                if (t >= 500)
                {
                    tt = 67.5;
                }
                if (t >= 750)
                {
                    tt = 74;
                }
                if (t >= 1000)
                {
                    tt = 78.5;
                }
            } 
            if (v>=100)
            {
                if (t >= 100)
                {
                    tt = 52.5;
                }
                if (t >= 200)
                {
                    tt = 59;
                }
                if (t >= 300)
                {
                    tt = 63.5;
                }
                if (t >= 400)
                {
                    tt = 68;
                }
                if (t >= 500)
                {
                    tt = 70.5;
                }
                if (t >= 750)
                {
                    tt = 76.5;
                }
                if (t >= 1000)
                {
                    tt = 80.5;
                }
            } 
            if (v>=200)
            {
                if (t >= 100)
                {
                    tt = 61;
                }
                if (t >= 200)
                {
                    tt = 66.5;
                }
                if (t >= 300)
                {
                    tt = 70;
                }
                if (t >= 400)
                {
                    tt = 72.5;
                }
                if (t >= 500)
                {
                    tt = 75.5;
                }
                if (t >= 750)
                {
                    tt = 79.5;
                }
                if (t >= 1000)
                {
                    tt = 0;
                }
            }
            if (v>=300)
            {
                if (t >= 100)
                {
                    tt = 68;
                }
                if (t >= 200)
                {
                    tt = 71.5;
                }
                if (t >= 300)
                {
                    tt = 74;
                }
                if (t >= 400)
                {
                    tt = 78.5;
                }
                if (t >= 500)
                {
                    tt = 0;
                }
            }
            return tt;
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pBartext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Vgtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void xText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pBtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void wGtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void fiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dPtext_TextChanged(object sender, EventArgs e)
        {

        }
        class GVPB
        {
            public GVPB(String S, String P, String D, String R, String razm, String m)
            {
                this.S = S;
                this.P = P;
                this.D = D;
                this.R = R;
                this.razm = razm;
                this.m = m;
            }
            String S;
            String P;
            String D;
            String R;
            String razm;
            String m;
            public override string ToString()
            {
                return $"Площадь сечения горловины, {S} м2 \n " +
                    $"Производительность, {P} м/ч \n " +
                    $"Диаметр горловины, {D} мм \n " +
                    $"Расход орошающей жидкости {R} \n " +
                    $"Габаритные размеры ШХГХВ, {razm} мм \n " +
                    $"Масса, {m} кг";
            }
        }

        private GVPB typeRazm(Double d)
        {
            if (d >= 0.006)
            {
                return new GVPB("0,006", "1700-3500", "85", "1,2-6,8", "560Х445Х1850", "70");
            }
            if (d >= 0.010)
            {
                return new GVPB("0,010", "3100-6500", "115", "2,9-12", "670Х540Х2500", "120");
            }
            if (d >= 0.014)
            {
                return new GVPB("0,014", "4140-8400", "135", "3,9-17", "700Х575Х2940", "150");
            }
            if (d >= 0.019)
            {
                return new GVPB("0,019", "5590-113450", "155", "5,2-23", "765Х645Х3140", "175");
            }
            if (d >= 0.025)
            {
                return new GVPB("0,025", "7450-15120", "180", "6,5-30", "795Х775Х3790", "257");
            }
            if (d >= 0.030)
            {
                return new GVPB("0,030", "7450-15120", "200", "10-38", "1355Х790Х4025", "310");
            }
            if (d >= 0.045)
            {
                return new GVPB("0,045", "9320-18900", "240", "13-56", "1420Х880Х4620", "420");
            }
            if (d >= 0.060)
            {
                return new GVPB("0,070", "13800-28000", "280", "17-75", "1630Х1075Х5425", "560");
            }
            if (d >= 0.080)
            {
                return new GVPB("0,080", "18630-37800", "320", "23-95", "1545Х1480Х5940", "675");
            }
            if (d >= 0.100)
            {
                return new GVPB("0,100", "23460-47600", "370", "29-132", "1860Х1835Х7550", "975");
            }
            if (d >= 0.140)
            {
                return new GVPB("0,140", "41400-84000", "420", "45-168", "2060Х2015Х9850", "1200");
            }
            return new GVPB("", "", "", "", "", "");
        }
    }
}
