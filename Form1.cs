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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Click[2] == 0)
            {
                pictureBox3.Image = Resource1.maru;
                Click[2] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (Click[5] == 0)
            {
                pictureBox6.Image = Resource1.maru;
                Click[5] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Click[4] == 0)
            {
                pictureBox5.Image = Resource1.maru;
                Click[4] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Click[3] == 0)
            {
                pictureBox4.Image = Resource1.maru;
                Click[3] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (Click[6] == 0)
            {
                pictureBox7.Image = Resource1.maru;
                Click[6] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Click[7] == 0)
            {
                pictureBox8.Image = Resource1.maru;
                Click[7] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (Click[8] == 0)
            {
                pictureBox9.Image = Resource1.maru;
                Click[8] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Click[0] == 0)
            {
                pictureBox1.Image = Resource1.maru;
                Click[0] = 1;
                Hantei();
                AIte();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Click[1] == 0)
            {
                pictureBox2.Image = Resource1.maru;
                Click[1] = 1;
                Hantei();
                AIte();
            }
        }

        private void AIte()
        {
            int line1 = Click[0] + Click[3] + Click[6],
                line2 = Click[1] + Click[4] + Click[7],
                line3 = Click[2] + Click[5] + Click[8],
                line4 = Click[0] + Click[4] + Click[8],
                line5 = Click[2] + Click[4] + Click[6],
                line6 = Click[0] + Click[1] + Click[2],
                line7 = Click[3] + Click[4] + Click[5],
                line8 = Click[6] + Click[7] + Click[8];
            if (line1 == 2)
                AIte_Hantei(1);
            else if (line2 == 2)
                AIte_Hantei(2);
            else if (line3 == 2)
                AIte_Hantei(3);
            else if (line4 == 2)
                AIte_Hantei(4);
            else if (line5 == 2)
                AIte_Hantei(5);
            else if (line6 == 2)
                AIte_Hantei(6);
            else if (line7 == 2)
                AIte_Hantei(7);
            else if (line8 == 2)
                AIte_Hantei(8);
            else
                AIte_Hantei(0);
        }

        private void AIte_Hantei(int n)
        {
            switch (n)
            {
                case 0:
                    Random rnd1 = new Random((int)(DateTime.Now.Ticks % Int32.MaxValue));
                    int i = rnd1.Next(9);
                    int j = 0;
                    while (Click[i] != 0)
                    {
                        i = rnd1.Next(9);
                        j++;
                        if (j > 20)
                            break;
                    }
                    AIte_Click(i);
                    break;
                case 1:
                    if (Click[0] == 0)
                        AI_Click1();
                    else if (Click[3] == 0)
                        AI_Click4();
                    else
                        AI_Click7();
                    break;
                case 2:
                    if (Click[1] == 0)
                        AI_Click2();
                    else if (Click[4] == 0)
                        AI_Click5();
                    else
                        AI_Click8();
                    break;
                case 3:
                    if (Click[2] == 0)
                        AI_Click3();
                    else if (Click[5] == 0)
                        AI_Click6();
                    else
                        AI_Click9();
                    break;
                case 4:
                    if (Click[0] == 0)
                        AI_Click1();
                    else if (Click[4] == 0)
                        AI_Click5();
                    else
                        AI_Click9();
                    break;
                case 5:
                    if (Click[2] == 0)
                        AI_Click3();
                    else if (Click[4] == 0)
                        AI_Click5();
                    else
                        AI_Click7();
                    break;
                case 6:
                    if (Click[0] == 0)
                        AI_Click1();
                    else if (Click[1] == 0)
                        AI_Click2();
                    else
                        AI_Click3();
                    break;
                case 7:
                    if (Click[3] == 0)
                        AI_Click4();
                    else if (Click[4] == 0)
                        AI_Click5();
                    else
                        AI_Click6();
                    break;
                case 8:
                    if (Click[6] == 0)
                        AI_Click7();
                    else if (Click[7] == 0)
                        AI_Click8();
                    else
                        AI_Click9();
                    break;
                default:
                    return;
            }
        }

        private void AIte_Click(int n)
        {
            switch (n)
            {
                case 0:
                    AI_Click1();
                    break;
                case 1:
                    AI_Click2();
                    break;
                case 2:
                    AI_Click3();
                    break;
                case 3:
                    AI_Click4();
                    break;
                case 4:
                    AI_Click5();
                    break;
                case 5:
                    AI_Click6();
                    break;
                case 6:
                    AI_Click7();
                    break;
                case 7:
                    AI_Click8();
                    break;
                case 8:
                    AI_Click9();
                    break;
                default:
                    return;
            }
        }

        private void AI_Click1()
        {
            pictureBox1.Image = Resource1.batu;
            Click[0] = 4;
            Hantei();
        }

        private void AI_Click2()
        {
            pictureBox2.Image = Resource1.batu;
            Click[1] = 4;
            Hantei();
        }

        private void AI_Click3()
        {
            pictureBox3.Image = Resource1.batu;
            Click[2] = 4;
            Hantei();
        }

        private void AI_Click4()
        {
            pictureBox4.Image = Resource1.batu;
            Click[3] = 4;
            Hantei();
        }

        private void AI_Click5()
        {
            pictureBox5.Image = Resource1.batu;
            Click[4] = 4;
            Hantei();
        }

        private void AI_Click6()
        {
            pictureBox6.Image = Resource1.batu;
            Click[5] = 4;
            Hantei();
        }

        private void AI_Click7()
        {
            pictureBox7.Image = Resource1.batu;
            Click[6] = 4;
            Hantei();
        }

        private void AI_Click8()
        {
            pictureBox8.Image = Resource1.batu;
            Click[7] = 4;
            Hantei();
        }

        private void AI_Click9()
        {
            pictureBox9.Image = Resource1.batu;
            Click[8] = 4;
            Hantei();
        }

        private void Hantei()
        {
            int line1 = Click[0] + Click[3] + Click[6],
                line2 = Click[1] + Click[4] + Click[7],
                line3 = Click[2] + Click[5] + Click[8],
                line4 = Click[0] + Click[4] + Click[8],
                line5 = Click[2] + Click[4] + Click[6],
                line6 = Click[0] + Click[1] + Click[2],
                line7 = Click[3] + Click[4] + Click[5],
                line8 = Click[6] + Click[7] + Click[8];
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
            else if (line6 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line6 == 12)
                MessageBox.Show("×の勝ち！");
            else if (line7 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line7 == 12)
                MessageBox.Show("×の勝ち！");
            else if (line8 == 3)
                MessageBox.Show("○の勝ち！");
            else if (line8 == 12)
                MessageBox.Show("×の勝ち！");
        }

    }
}
