using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App1
{
    public partial class ChangeHour : Form
    {
        public ChangeHour()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {  
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            if (textBox1.Text.Length > 0)
            {
                double result = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString(result * 60);
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
