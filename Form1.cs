using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaruBatuGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] Click = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int Count = 1;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Click[2] == 0)
            {
                if (Count == 1)
                {
                    pictureBox3.Image = Resource1.maru;
                    Count = 2;
                    Click[2] = 1;
                }
                else
                {
                    pictureBox3.Image = Resource1.batu;
                    Count = 1;
                    Click[2] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Click[5] == 0)
            {
                if (Count == 1)
                {
                    pictureBox6.Image = Resource1.maru;
                    Count = 2;
                    Click[5] = 1;
                }
                else
                {
                    pictureBox6.Image = Resource1.batu;
                    Count = 1;
                    Click[5] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Click[4] == 0)
            {
                if (Count == 1)
                {
                    pictureBox5.Image = Resource1.maru;
                    Count = 2;
                    Click[4] = 1;
                }
                else
                {
                    pictureBox5.Image = Resource1.batu;
                    Count = 1;
                    Click[4] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Click[3] == 0)
            {
                if (Count == 1)
                {
                    pictureBox4.Image = Resource1.maru;
                    Count = 2;
                    Click[3] = 1;
                }
                else
                {
                    pictureBox4.Image = Resource1.batu;
                    Count = 1;
                    Click[3] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Click[6] == 0)
            {
                if (Count == 1)
                {
                    pictureBox7.Image = Resource1.maru;
                    Count = 2;
                    Click[6] = 1;
                }
                else
                {
                    pictureBox7.Image = Resource1.batu;
                    Count = 1;
                    Click[6] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Click[7] == 0)
            {
                if (Count == 1)
                {
                    pictureBox8.Image = Resource1.maru;
                    Count = 2;
                    Click[7] = 1;
                }
                else
                {
                    pictureBox8.Image = Resource1.batu;
                    Count = 1;
                    Click[7] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Click[8] == 0)
            {
                if (Count == 1)
                {
                    pictureBox9.Image = Resource1.maru;
                    Count = 2;
                    Click[8] = 1;
                }
                else
                {
                    pictureBox9.Image = Resource1.batu;
                    Count = 1;
                    Click[8] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Click[0] == 0)
            {
                if (Count == 1)
                {
                    pictureBox1.Image = Resource1.maru;
                    Count = 2;
                    Click[0] = 1;
                }
                else
                {
                    pictureBox1.Image = Resource1.batu;
                    Count = 1;
                    Click[0] = 4;
                }
            }
            Hantei();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Click[1] == 0)
            {
                if (Count == 1)
                {
                    pictureBox2.Image = Resource1.maru;
                    Count = 2;
                    Click[1] = 1;
                }
                else
                {
                    pictureBox2.Image = Resource1.batu;
                    Count = 1;
                    Click[1] = 4;
                }
            }
            Hantei();
        }

        private void AIte()
        {

        }

        private void Hantei()
        {
            int line1 = Click[0] + Click[3] + Click[6],
                line2 = Click[1] + Click[4] + Click[7],
                line3 = Click[2] + Click[5] + Click[8],
                line4 = Click[0] + Click[4] + Click[8],
                line5 = Click[2] + Click[4] + Click[6];
            if (line1 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line1 == 12)
                MessageBox.Show("×の勝ち！");
            else if (line2 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line2 == 12)
                MessageBox.Show("×の勝ち！");
            else if (line3 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line3 == 12)
                MessageBox.Show("×の勝ち！");
            else if (line4 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line4 == 12)
                MessageBox.Show("×の勝ち！");
            else if (line5 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line5 == 12)
                MessageBox.Show("×の勝ち！");
        }

    }
}
