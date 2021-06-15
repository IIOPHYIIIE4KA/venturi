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
                    && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
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
    }
}
