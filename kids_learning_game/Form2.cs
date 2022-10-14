using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_learning_game
{
    public partial class Form2 : Form
    {
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
        private int score=0;
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void Animals_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                score++;
                label15.Text = (score * 5).ToString();
            }
            else
            {
                score--;
                label15.Text = (score * 5).ToString();
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                score++;
                label15.Text = (score * 5).ToString();
            }
            else
            {
                score--;
                label15.Text = (score * 5).ToString();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
           if( radioButton9.Checked == true)
            {
                score++;
                label15.Text = (score * 5).ToString();
            }
           else
            {
                score--;
                label15.Text = (score * 5).ToString();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if( (radioButton6.Checked == true) )
            {
                score++;
                label15.Text = (score * 5).ToString();
            }
            else
            {
                score--;
                label15.Text = (score * 5).ToString();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text=(score*5).ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
