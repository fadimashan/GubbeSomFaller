using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GubbeSomFaller
{
    public partial class Form1 : Form
    {
        int navigate = 20;
        public Form1()
        {
            InitializeComponent();
            tbxGissa.Enabled = false;
            lblSexBokst.Visible = false;
            comboBox1.SelectedIndex = 0;

        }




        private void pbxSky_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void tbxSvar_TextChanged(object sender, EventArgs e)
        {
            lblResutate.Text = "Gissa på en bokstav";
            choseLevel();



            /** if the tbxSvar is not null or empty and the length not 6 so disable tbxGissa **/
            if (!String.IsNullOrEmpty(tbxSvar.Text) && tbxSvar.Text.Length != 6)
            {
                lblSexBokst.Visible = true;
                tbxGissa.Enabled = false;
                tbxVisa.Text = "";

                return;
            }
            else if (tbxSvar.Text.Length == 6)
            {
                lblSexBokst.Visible = false;
                tbxGissa.Enabled = true;
                tbxVisa.Text = "??????";
            }
        }


        private void tbxVisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxGissa_TextChanged(object sender, EventArgs e)
        {
            choseLevel();
            tbxSvar.Enabled = false;
            string gissaChar = tbxGissa.Text;

            /** this code can catch the char one time **/

            //if (!string.IsNullOrEmpty(gissaChar) && svarTxt.Contains(gissaChar))
            //{
            //    int index = tbxSvar.Text.IndexOf(tbxGissa.Text);
            //    string temp = tbxVisa.Text.Remove(index, 1);
            //    tbxVisa.Text = temp.Insert(index, tbxGissa.Text);
            //    tbxGissa.Text = null;
            //    return;
            //} else
            //{
            //    tbxGissa.Text = "";
            //}


            /** this work with catching more than one letter and replace it**/
            int num;
            for (int i = 0; i < 6; i++)
            {
                num = i;
                if (tbxGissa.Text == tbxSvar.Text[i].ToString())
                {
                    string temp = tbxVisa.Text.Remove(i, 1);
                    tbxVisa.Text = temp.Insert(i, tbxGissa.Text);
                    num = i;
                }
            }


            /** Navigate step down if the guess not correct**/
            if (!tbxVisa.Text.Contains(gissaChar))
            {
                pbxGubbe.Location = new Point(pbxGubbe.Location.X, pbxGubbe.Location.Y + navigate);
                tbxGissa.Text = "";
            }
            else
            {
                tbxGissa.Text = "";

            }

            /** When there is no more "?" in the tbxVisa (Player won) **/
            if (!tbxVisa.Text.Contains('?'))
            {
                lblResutate.Text = "Gratis! Du vann!";
                pbxGubbe.Location = new Point(pbxGubbe.Location.X, 99);
                tbxSvar.Text = "";
                tbxVisa.Text = "";
                tbxSvar.Enabled = true;
                tbxGissa.Enabled = false;

            }

            /** Player lost **/
            if (pbxGubbe.Bottom >= pbxSky.Bottom)
            {
                lblResutate.Text = "Game Over!";
                MessageBox.Show("Game over!", "Reset");
                tbxSvar.Text = "";
                tbxVisa.Text = "";
                lblResutate.Text = "Gissa på en bokstav";
                pbxGubbe.Location = new Point(pbxGubbe.Location.X, 99);
                return;

            }

        }

        public void choseLevel()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    navigate = 20;
                    break;

                case 1:
                    navigate = 40;
                    break;

                default:
                    break;

            }

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
