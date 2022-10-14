using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_learning_game
{
    public partial class Form3 : Form
    {
        private int score = 0;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked==true)
            {
                score++;
                label20.Text = (score * 5).ToString();
            }
            else
            {
                score--;

                label20.Text = (score * 5).ToString();
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if( radioButton14.Checked==true)
            {
                score++;

                label20.Text = (score * 5).ToString();
            }
            else
            {
                score--;

                label20.Text = (score * 5).ToString();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton11.Checked==true)
            {
                score++;
                label20.Text = (score * 5).ToString();
            }
            else
            {
                score -= 1;
                label20.Text = (score * 5).ToString();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton8.Checked==true)
            {
                score++;
                label20.Text = (score * 5).ToString();
            }
            else
            {
                score--;
                label20.Text = (score * 5).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label20.Text = (score * 5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kids_Game Check = new Kids_Game();

            Check.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
