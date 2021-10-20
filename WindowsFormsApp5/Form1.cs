using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp5
{

    public partial class Form1 : Form
    {

        private Scrubber scrubber = null;

        public Form1()
        {
            InitializeComponent();
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
                    && e.KeyChar != ',')
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

        class Scrubber
        {
            public Double V0c { get; set; }
            public Double tM { get; set; }
            public Double i1 { get; set; }
            public Double i2 { get; set; }
            public Double Q { get; set; }
            public Double dTavg { get; set; }
            public Double Mb { get; set; }
            public Double x2 { get; set; }
            public Double Vg { get; set; }
            public Double p2 { get; set; }
            public Double k0 { get; set; }
            public Double vc { get; set; }
            public Double d { get; set; }
            public Double h { get; set; }
            public Double hd { get; set; }
            public Double Kch { get; set; }
            public Double Nch { get; set; }
            public Double n { get; set; }
            public Double iP { get; set; }
            public Double tk { get; set; }
            public Double i { get; set; }

            public Double Vgg { get; set; }
            public Double Pbar { get; set; }
            public Double T { get; set; }
            public Double X { get; set; }
            public Double Wg { get; set; }
            public Double Pb { get; set; }
            public Double Fi { get; set; }
            public Double P0 { get; set; }
            public Double Pg { get; set; }

            public Scrubber(Double Vgg, Double Pbar, Double T, Double X, Double Wg, Double Pb, Double Fi, Double P0, Double Pg)
            {
                this.Vgg = Vgg;
                this.Pbar = Pbar;
                this.T = T;
                this.X = X;
                this.Pb = Pb;
                this.Fi = Fi;
                this.P0 = P0;
                this.Pg = Pg;
                this.Wg = Wg;
            }

            public void calculate()
            {
                tM = getTemp(X * 1000, T);
                V0c = (Vgg * 0.804 * 274 * (Pbar - Pg)) / (tM * (0.804 + X) * (273 + T) * Pbar);
                i1 = 2480 + T * 1.96;
                i2 = 2489 + tM * 1.96;
                iP = (i1 + i2) / 2;
                Q = V0c * (1.3 * (T - tM) + X * (i1 - i2));
                dTavg = ((T - tM - 5) - (tM - 20)) / (2.3 * Math.Log10((T - tM - 5) / (tM - 20)));
                tk = tM - 5;
                i = entropy(tk);
                Mb = Q / (Fi * (iP - i) + (1 - 0.5) * (230 - i));
                x2 = X + (Fi * Mb) / V0c;
                Vg = V0c * (((0.804 + x2) * (273 + tM) * Pbar) / (0.804 * 273 * (Pbar + Pg)));
                p2 = ((P0 + x2) * 0.804 * 273 * (Pbar + Pg)) / ((0.804 + x2) * (273 + tM) * Pbar);
                k0 = (116 + 525 * ((Mb) / (Vg * p2))) * (1 + 0.001 * 113);
                vc = Q * 1000 / (k0 * dTavg);
                d = Math.Sqrt(Vg / (0.785 * Wg));
                h = 2.5 * d;
            }

            private static Double entropy(double t)
            {
                Double i = 0;
                if (t == 0)
                {
                    i = 0;
                }
                if (t <= 10)
                {
                    i = 42.04;
                }
                if (t <= 20)
                {
                    i = 83.91;
                }
                if (t <= 30)
                {
                    i = 125.7;
                }
                if (t <= 40)
                {
                    i = 167.5;
                }
                if (t <= 50)
                {
                    i = 209.3;
                }
                if (t <= 55)
                {
                    i = 230;
                }
                if (t <= 60)
                {
                    i = 251.1;
                }
                if (t <= 70)
                {
                    i = 293;
                }
                if (t <= 80)
                {
                    i = 355;
                }
                if (t <= 90)
                {
                    i = 377;
                }
                if (t <= 100)
                {
                    i = 419.1;
                }
                return i;
            }

            private static double getTemp(double v, double t)
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
                if (v >= 100)
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
                if (v >= 200)
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
                if (v >= 300)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
                scrubber = new Scrubber(Vgg, Pbar, T, X, Wg, Pb, Fi, P0, Pg);
                scrubber.calculate();

               
                v0Label.Text = "= " + Math.Round(scrubber.V0c, 2).ToString();
                String tm = "";
                if (scrubber.tM == 0)
                {
                    tm = "-";
                } else
                {
                    tm = Math.Round(scrubber.tM, 2).ToString();
                }
                tmLabel.Text = "Температура мокрого термометра °С = " + tm;
                i1Label.Text = "= " + Math.Round(scrubber.i1, 2).ToString();
                i2Label.Text = "= " + Math.Round(scrubber.i2, 2).ToString();
                qLabel.Text = "= " + Math.Round(scrubber.Q, 2).ToString();
                dTlabel.Text = "= " + Math.Round(scrubber.dTavg, 2).ToString();
                mBlabel.Text = "= " + Math.Round(scrubber.Mb, 2).ToString();
                x2Label.Text = "= " + Math.Round(scrubber.x2, 2).ToString();
                vgLabel.Text = "= " + Math.Round(scrubber.Vg, 2).ToString();
                p2Label.Text = "= " + Math.Round(scrubber.p2, 2).ToString();
                k0Label.Text = "= " + Math.Round(scrubber.k0, 2).ToString();
                vClabel.Text = "= " + Math.Round(scrubber.vc, 2).ToString();
                dLabel.Text = "= " + Math.Round(scrubber.d, 2).ToString();
                hLabel.Text = "= " + Math.Round(scrubber.h, 2).ToString();
                p2Label.Text = "= " + Math.Round(scrubber.p2, 2).ToString();
                vClabel.Text = "= " + Math.Round(scrubber.vc, 2).ToString();
                dLabel.Text = "= " + Math.Round(scrubber.d, 2).ToString();
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



        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scrubber == null)
            {
                _ = MessageBox.Show("Сначала проведите расчеты");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Json|*.json";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize(scrubber);
                    File.WriteAllText(saveFileDialog1.FileName, jsonString);
                    _ = MessageBox.Show("Сохранено");
                } catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Json|*.json";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    scrubber = JsonSerializer.Deserialize<Scrubber>(text);
                    v0Label.Text = "= " + Math.Round(scrubber.V0c, 2).ToString();
                    String tm = "";
                    if (scrubber.tM == 0)
                    {
                        tm = "-";
                    }
                    else
                    {
                        tm = Math.Round(scrubber.tM, 2).ToString();
                    }
                    Vgtext.Text = Convert.ToString(scrubber.Vgg);
                    pBartext.Text = Convert.ToString(scrubber.Pbar);
                    tText.Text = Convert.ToString(scrubber.T);
                    xText.Text = Convert.ToString(scrubber.X * 1000);
                    pBtext.Text = Convert.ToString(scrubber.Pb);
                    fiText.Text = Convert.ToString(scrubber.Fi);
                    dPtext.Text = Convert.ToString(scrubber.P0);
                    pgTextt.Text = Convert.ToString(scrubber.Pg);
                    wGtext.Text = Convert.ToString(scrubber.Wg);
                    tmLabel.Text = "Температура мокрого термометра °С = " + tm;
                    i1Label.Text = "= " + Math.Round(scrubber.i1, 2).ToString();
                    i2Label.Text = "= " + Math.Round(scrubber.i2, 2).ToString();
                    qLabel.Text = "= " + Math.Round(scrubber.Q, 2).ToString();
                    dTlabel.Text = "= " + Math.Round(scrubber.dTavg, 2).ToString();
                    mBlabel.Text = "= " + Math.Round(scrubber.Mb, 2).ToString();
                    x2Label.Text = "= " + Math.Round(scrubber.x2, 2).ToString();
                    vgLabel.Text = "= " + Math.Round(scrubber.Vg, 2).ToString();
                    p2Label.Text = "= " + Math.Round(scrubber.p2, 2).ToString();
                    k0Label.Text = "= " + Math.Round(scrubber.k0, 2).ToString();
                    vClabel.Text = "= " + Math.Round(scrubber.vc, 2).ToString();
                    dLabel.Text = "= " + Math.Round(scrubber.d, 2).ToString();
                    hLabel.Text = "= " + Math.Round(scrubber.h, 2).ToString();
                    p2Label.Text = "= " + Math.Round(scrubber.p2, 2).ToString();
                    vClabel.Text = "= " + Math.Round(scrubber.vc, 2).ToString();
                    dLabel.Text = "= " + Math.Round(scrubber.d, 2).ToString();
                    _ = MessageBox.Show("Загружено");
                }
                catch (IOException ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
