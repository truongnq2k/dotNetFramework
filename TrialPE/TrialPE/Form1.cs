using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrialPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random generator = new Random();
            //string r = generator.Next(0, 1000000).ToString("D6");
            textBox1.Text = "HE140426";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                panel2.BackColor = colorDialog1.Color;
            }
        }

        List<Button> b = new List<Button>();

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = textBox2.Text;
            btn.BackColor = panel2.BackColor;
            b.Add(btn);
            flowLayoutPanel1.Controls.Add(btn);

            foreach(Button s in b)
            {
                s.MouseClick += Button_Click;
            }
        }


        public void Button_Click(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            Color color = ((Button)sender).BackColor;
            string message = text + Convert.ToString(color);
            MessageBox.Show(message);
        }

    }
}
