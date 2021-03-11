using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaba1_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cav_filling = 550;    int x_ray = 100;       int root_canal = 670;
        int i_1 = 0;        int i_2 = 0;        int i_3 = 0;        int sum = 0;
        string services;
        
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            i_1++;
            button1.Text = Convert.ToString(i_1);
            sum += i_1 * x_ray;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            i_2++;
            button2.Text = Convert.ToString(i_2);
            sum += i_2 * cav_filling ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label10.Text = "До сплати: " + sum + " грн.";
            label11.Text = "Обрані послуги: " + services;
            sum = 0;
            i_1 = i_2 = i_3 = 0;
            button1.Text = button2.Text = button4.Text = "0";
            services = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i_3++;
            button4.Text = Convert.ToString(i_3);
            sum += i_3 * root_canal;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sum += 250;
            services += "cleaning, ";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (i_1 < 1)
            {
                button2.Text = "1";
                i_1 = 1;
                sum += 550;
            }
            services += "cavity filling, ";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (i_2 < 1)
            {
                button1.Text = "1";
                i_2 = 1;
                sum += 100;
            }
            services += "x-ray , ";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            sum += 420;
            services += "fluoride, ";
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (i_3 < 1)
            {
                button4.Text = "1";
                i_3 = 1;
                sum += 670;
            }
            services += "root canal, ";
        }
    }
}
