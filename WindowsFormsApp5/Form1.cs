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

        private void pgtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(pgtextBox2, e);
        }

        private void wtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(wtextBox, e);
        }

        private void epstextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(epstextbox, e);
        }

        private void pgtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(pgtextbox, e);
        }

        private void pgtextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
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

        private void ectext_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(ectext, e);
        }

        private void pgtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(pgtext, e);
        }

        private void wgtext2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(wgtext2, e);
        }

        private void pgtext2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(pgtext2, e);
        }

        private void etext_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(etext, e);
        }

        private void mtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateTextbox(mtext, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
