using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansör_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                

    private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (label8.Text == "1")
            {
                pictureBox2.Top -= 5;

                if (pictureBox2.Location.Y <= 550)
                {
                    timer1.Stop();
                }
            }
            if (label8.Text == "2")
            {
                pictureBox2.Top -= 5;
                if (pictureBox2.Location.Y <= 455)
                {
                    timer1.Stop();
                }

            }
            if (label8.Text == "3")
            {
                pictureBox2.Top -= 5;
                if (pictureBox2.Location.Y <= 362)
                {
                    timer1.Stop();
                }
            }
            if (label8.Text == "4")
            {
                pictureBox2.Top -= 5;
                if (pictureBox2.Location.Y <= 264)
                {
                    timer1.Stop();
                }
            }
            if (label8.Text == "5")
            {
                pictureBox2.Top -= 5;
                if (pictureBox2.Location.Y <= 165)
                {
                    timer1.Stop();
                }
            }
            if (label8.Text == "in1")
            {
                pictureBox2.Top += 5;
                if (pictureBox2.Location.Y >= 550)
                {
                    timer1.Stop();
                }
            }
            if (label8.Text == "in2")
            {
                pictureBox2.Top += 5;
                if (pictureBox2.Location.Y >= 455)
                {
                    timer1.Stop();
                }
            }
            if (label8.Text  == "in3")
            {
                pictureBox2.Top += 5;
                if (pictureBox2.Location.Y >= 362)
                {
                    timer1.Stop();
                    label8.Text = "3. KATA İNİLDİ";
                }
            }
            if (label8.Text == "in4")
            {
                pictureBox2.Top += 5;
                if (pictureBox2.Location.Y >= 264)
                {
                    timer1.Stop();
                    label8.Text = "4. KATA İNİLDİ";
                }
            }

            if (label8.Text == "0")
            {
                pictureBox2.Top -= 5;
                if (pictureBox2.Location.Y <= 722)
                {
                    timer1.Stop();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "kat1";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label17.Text == "kat1")
            {
                pictureBox3.Top -= 5;
                if (pictureBox3.Location.Y <= 549)
                {
                    timer2.Stop();
                }

            }
            if (label17.Text == "kat2")
            {
                pictureBox3.Top -= 5;
                if (pictureBox3.Location.Y <= 455)
                {
                    timer2.Stop();
                }
            }
            if (label17.Text == "kat3")
            {
                pictureBox3.Top -= 5;
                if (pictureBox3.Location.Y <= 362)
                {
                    timer2.Stop();
                }
            }
            if (label17.Text == "kat4")
            {
                pictureBox3.Top -= 5;
                if (pictureBox3.Location.Y <= 264)
                {
                    timer2.Stop();
                }
            }
            if (label17.Text == "kat5")
            {
                pictureBox3.Top -= 5;
                if (pictureBox3.Location.Y <= 165)
                {
                    timer2.Stop();
                }
            }
            if (label17.Text == "inn1")
            {
                pictureBox3.Top += 5;
                if (pictureBox3.Location.Y >= 549)
                {
                    timer1.Stop();
                    label17.Text = "1. KATA İNİLDİ";
                }
            }
            if (label17.Text == "inn2")
            {
                pictureBox3.Top += 5;
                if (pictureBox3.Location.Y >= 455)
                {
                    timer2.Stop();
                    label17.Text = "2. KAT İNİLDİ";
                }
            }
            if (label17.Text == "inn3")
            {
                pictureBox3.Top += 5;
                if (pictureBox3.Location.Y >= 362)
                {
                    timer2.Stop();
                }
            }
            if (label17.Text == "inn4")
            {
                pictureBox3.Top += 5;
                if(pictureBox3.Location.Y>= 264)
                {
                    timer2.Stop();
                    label17.Text = "4. KAT İNİLDİ";
                }
            }
            if (label17.Text == "0")
            {
                pictureBox3.Top -= 5;
                if (pictureBox3.Location.Y <= 722)
                {
                    timer2.Stop();
                    
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "kat2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "kat3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "kat4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "kat5";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "in1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "in2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "in3";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "in4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "inn1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "inn2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "inn3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label17.Text = "inn4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            timer2.Start();
            label17.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label8.Text = "0";
            pictureBox7.Visible = false;
        }

    private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
