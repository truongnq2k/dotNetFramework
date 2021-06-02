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
            calculTime(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            double result = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString(result * 60);
            calculTime(textBox2.Text);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
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
                calculTime(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }


        private void calculTime(string minutes)
        {
            int day, hour, minute, temp;
            int totalminutes = Convert.ToInt32(minutes);
            day = totalminutes / (24 * 60);
            textBox3.Text = Convert.ToString(day);
            temp = totalminutes % (24 * 60);
            hour = temp / 60;
            textBox4.Text = Convert.ToString(hour);
            minute = temp % 60;
            textBox5.Text = Convert.ToString(minute);
        }
    }
}
