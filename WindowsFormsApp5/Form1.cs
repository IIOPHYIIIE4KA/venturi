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
                tM = getTemp(X * 1000, T);
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
                v0Label.Text = "= " + Math.Round(V0c, 2).ToString();
                tmLabel.Text = "Температура мокрого термометра °С = " + Math.Round(tM, 2).ToString();
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
                HDLabel.Text = "= " + Math.Round(hd, 2).ToString();
                p2Label.Text = "= " + Math.Round(p2, 2).ToString();
                vClabel.Text = "= " + Math.Round(vc, 2).ToString();
                dLabel.Text = "= " + Math.Round(d, 2).ToString();
                kHlabel.Text = "= " + Math.Round(Kch, 2).ToString();
                NLabel.Text = "= " + Math.Round(Nch, 2).ToString();
                nuLabel.Text = "= " + Math.Round(n, 2).ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Double n = 0;
            Double Ng = 0;
            Double kg = 0;
            Double dp = 0;
            Double p1 = 0;
            Double V1 = 0;
            Double Mv = 0;
            Double T2 = 0;
            Double p2 = 0;
            Double V2 = 0;
            Double D = 0;
            Double H = 0;
            Double dpc = 0;
            Double pc = 0;
            Double Eg = 0;
            Double w2 = 0;
            Double d2 = 0;

            Double V0 = 0;
            Double E = 0;
            Double Tg = 0;
            Double P1 = 0;
            Double p0 = 0;
            Double z = 0;
            Double P2 = 0;
            Double Tn = 0;
            Double zz = 0;
            Double m = 0;
            try
            {
                V0 = Convert.ToDouble(v0_vent.Text);
                E = Convert.ToDouble(e_vent.Text);
                Tg = Convert.ToDouble(tg_vent.Text);
                P1 = Convert.ToDouble(p1_vent.Text);
                p0 = Convert.ToDouble(p0_vent.Text);
                z = Convert.ToDouble(z_vent.Text);
                P2 = Convert.ToDouble(p2_vent.Text);
                Tn = Convert.ToDouble(tn_vent.Text);
                zz = Convert.ToDouble(zz_vent.Text);
                m = Convert.ToDouble(m_vent.Text);

                n = 1 - (z/zz);
                Ng = Math.Log(1/(1-n));
                kg = Math.Pow((Ng / 6.9 * 1000), 1.493);
                dp = kg-300000*0.0012;
                p1 = p0*((273*(101.3-1.2))/((273+Tg)*101.3));
                V1 = V0*p0/(p1*3600);
                Mv = V1*m;
                T2 = (0.133-0.041*m)*Tg + 35;
                p2 = 163 + (0.063*(101.3-1.2-12)*0.804)/((273 + T2) * 101.3 * (0.804 + 0.063));
                V2 = V0*p0/(p2*3600);
                D = 1.13*Math.Sqrt(0.73/2.5);
                H = 2.5*D;
                dpc = E*2.5*2.5*0.96/2;
                pc = dp - dpc;
                Eg = 0.63*0.145*Math.Pow(m, -0.3);
                w2 = Math.Sqrt((2*12440)/(0.145*p2 + Eg*1060*m));
                d2 = 1.13 * Math.Sqrt(V2 / w2);

                n_vent.Text = "= " + Math.Round(n, 2).ToString();
                ng_vent.Text = "= " + Math.Round(Ng, 2).ToString();
                kg_vent.Text = "= " + Math.Round(kg, 2).ToString();
                dp_vent.Text = "= " + Math.Round(dp, 2).ToString();
                po1_vent.Text = "= " + Math.Round(p1, 2).ToString();
                v1_vent.Text = "= " + Math.Round(V1, 2).ToString();
                mv_vent.Text = "= " + Math.Round(Mv, 2).ToString();
                t2_vent.Text = "= " + Math.Round(T2, 2).ToString();
                po2_vent.Text = "= " + Math.Round(p2, 2).ToString();
                v2_vent.Text = "= " + Math.Round(V2, 2).ToString();
                d_vent.Text = "= " + Math.Round(D, 2).ToString();
                h_vent.Text = "= " + Math.Round(H, 2).ToString();
                dpc_vent.Text = "= " + Math.Round(dpc, 2).ToString();
                pc_vent.Text = "= " + Math.Round(pc, 2).ToString();
                eg_vent.Text = "= " + Math.Round(Eg, 2).ToString();
                w2_vent.Text = "= " + Math.Round(w2, 2).ToString();
                d2_vent.Text = "= " + Math.Round(d2, 2).ToString();
                label28.Text = typeRazm(d2).ToString();
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
