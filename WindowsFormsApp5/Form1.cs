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

        private void buttoncalc1_Click(object sender, EventArgs e)
        {
            Double dP0 = 0;
            Double dPg = 0;
            Double dPk = 0;

            Double E = 0;
            Double P = 0;
            Double w = 0;
            try
            {
                E = Convert.ToDouble(epstextbox.Text);
                P = Convert.ToDouble(pgtextBox2.Text);
                w = Convert.ToDouble(wtextBox.Text);
                dPk = E * (w * w * P) / 2;
                pklabel.Text = "ΔPк = " + dPk.ToString();
                dPg = Convert.ToDouble(pgtextbox.Text);
                dP0 = dPk + dPg;
                polabel.Text = "ΔP0 = " + dP0.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Double dPt = 0;
            Double dPc = 0;
            Double dPg = 0;

            Double Ec = 0;
            Double Pg = 0;

            Double Eg = 0;
            Double wg = 0;
            Double pg = 0;

            Double E = 0;
            Double M = 0;
            try
            {
                E = Convert.ToDouble(etext.Text);
                M = Convert.ToDouble(mtext.Text);
                wg = Convert.ToDouble(wgtext2.Text);
                pg = Convert.ToDouble(pgtext2.Text);
                Ec = Convert.ToDouble(ectext.Text);
                Pg = Convert.ToDouble(pgtext.Text);
                Eg = 0.63 * E * Math.Pow(M, -0.3);
                eglabel.Text = "εж = " + Eg.ToString();
                dPg = Eg * (M * wg * pg) / 2;
                pglabel.Text = "ΔPж = " + Pg.ToString();
                dPc = Ec * (wg * wg * pg) / 2;
                pclabel.Text = "ΔPс = " + dPc.ToString();
                dPt = dPg + dPc;
                ptlabel.Text = "ΔPт = " + dPt.ToString();
            } catch (FormatException ex)
            {
                MessageBox.Show("Неверные данные, проверьте поля");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            Double Vgg = 0;
            Double Pbar = 0;
            Double T = 0;
            Double X = 0;
            Double Wg = 0;
            Double Pb = 0;
            Double Fi = 0;
            Double dP = 0;
            Double Pg = 0;
            try
            {
                Vgg = Convert.ToDouble(Vgtext.Text);
                Pbar = Convert.ToDouble(pBartext.Text);
                T = Convert.ToDouble(tText.Text);
                X = Convert.ToDouble(xText.Text) * 0.001;
                Pb = Convert.ToDouble(pBtext.Text);
                Fi = Convert.ToDouble(fiText.Text);
                dP = Convert.ToDouble(dPtext.Text);
                Pg = Convert.ToDouble(pgTextt.Text);
                Wg = Convert.ToDouble(wGtext.Text);

                V0c = (Vgg * 0.804*274*(Pbar-Pg))/(60*(0.804+X)*(273+300)*101.3);
                tM = getTemp(V0c, T);
                i1 = 2480+ T*1.96;
                i2 = 2489 + tM * 1.96;
                Q = V0c*(1.3*(T-tM)+X*(i1-i2));
                dTavg = ((T - tM - 5) - (tM - 20)) / (2.3 * Math.Log10((T - tM - 5) / (tM - 20)));
                Mb = Q/(Fi*(2778-84) + (1-0.5)*(230-84));
                x2 = X  + (Fi*Mb)/V0c;
                Vg = V0c*(((0.804+x2)*(273+tM)*Pbar)/(0.804*273*(Pbar+Pg)));
                p2 = ((1.3+x2)*0.804*273*(Pbar+Pg))/((0.804+x2)*(273+tM)*Pbar);
                k0 = (116+525*((Mb)/(Vg*p2)))*(1+0.001*113);
                vc = Q*1000/(k0*dTavg);
                d = Math.Sqrt(vc/(0.785*Wg));
                h = vc/(0.785*d*d);
                hd = h/d;
                Kch = dP + Pb*1000*0.016/Vg;
                Nch = 6.61*0.001 * Math.Pow(Kch, 0.891);
                n = 1-(-Math.Exp(Nch));
                v0Label.Text = "= " + V0c.ToString();
                tmLabel.Text = "Температура мокрого термометра °С = " + tM.ToString();
                i1Label.Text = "= " + i1.ToString();
                i2Label.Text = "= " + i2.ToString();
                qLabel.Text = "= " + Q.ToString();
                dTlabel.Text = "= " + dTavg.ToString();
                mBlabel.Text = "= " + Mb.ToString();
                x2Label.Text = "= " + x2.ToString();
                vgLabel.Text = "= " + Vg.ToString();
                p2Label.Text = "= " + p2.ToString();
                k0Label.Text = "= " + k0.ToString();
                vClabel.Text = "= " + vc.ToString();
                dLabel.Text = "= " + d.ToString();
                hLabel.Text = "= " + h.ToString();
                HDLabel.Text = "= " + hd.ToString();
                p2Label.Text = "= " + p2.ToString();
                vClabel.Text = "= " + vc.ToString();
                dLabel.Text = "= " + d.ToString();
                kHlabel.Text = "= " + Kch.ToString();
                NLabel.Text = "= " + Nch.ToString();
                nuLabel.Text = "= " + n.ToString();
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

        private double getTemp(double v, double t)
        {
            double tt = 0;
            if (v <= 25)
            {
                if (t <= 100)
                {
                    tt = 38.5;
                }
                else if (t <= 200)
                {
                    tt = 49.5;
                }
                else if (t <= 300)
                {
                    tt = 57;
                }
                else if (t <= 400)
                {
                    tt = 62;
                }
                else if (t <= 500)
                {
                    tt = 65;
                }
                else if (t <= 750)
                {
                    tt = 72.5;
                }
                else if (t <= 1000)
                {
                    tt = 77.5;
                }
            } else if (v <= 50)
            {
                if (t <= 100)
                {
                    tt = 44;
                }
                else if (t <= 200)
                {
                    tt = 53;
                }
                else if (t <= 300)
                {
                    tt = 59.5;
                }
                else if (t <= 400)
                {
                    tt = 64;
                }
                else if (t <= 500)
                {
                    tt = 67.5;
                }
                else if (t <= 750)
                {
                    tt = 74;
                }
                else if (t <= 1000)
                {
                    tt = 78.5;
                }
            } else if (v<=100)
            {
                if (t <= 100)
                {
                    tt = 52.5;
                }
                else if (t <= 200)
                {
                    tt = 59;
                }
                else if (t <= 300)
                {
                    tt = 63.5;
                }
                else if (t <= 400)
                {
                    tt = 68;
                }
                else if (t <= 500)
                {
                    tt = 70.5;
                }
                else if (t <= 750)
                {
                    tt = 76.5;
                }
                else if (t <= 1000)
                {
                    tt = 80.5;
                }
            } else if (v<=200)
            {
                if (t <= 100)
                {
                    tt = 61;
                }
                else if (t <= 200)
                {
                    tt = 66.5;
                }
                else if (t <= 300)
                {
                    tt = 70;
                }
                else if (t <= 400)
                {
                    tt = 72.5;
                }
                else if (t <= 500)
                {
                    tt = 75.5;
                }
                else if (t <= 750)
                {
                    tt = 79.5;
                }
            } else if (v<=300)
            {
                if (t <= 100)
                {
                    tt = 68;
                }
                else if (t <= 200)
                {
                    tt = 71.5;
                }
                else if (t <= 300)
                {
                    tt = 74;
                }
                else if (t <= 400)
                {
                    tt = 78.5;
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
    }
}
