using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slideshow
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox5.Visible = true;
            pictureBox4.Visible = true;
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
           
            if (pictureBox1.Visible == true)
            {
                pictureBox4.Visible = false;
               
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox5.Visible = false;
                
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox6.Visible = false;
                
            }
        }
    }
}
