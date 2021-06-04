using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace App2
{
    public partial class CoraPad : Form
    {
        public CoraPad()
        {
            InitializeComponent();
        }

        private string file = "";
        private string about = "First of all, thank you for asking and I am happy to introduce that my name is Quang Truong. I am 21 years old. I was born in the suburbs of Hanoi but now I live and work at FPT University.";

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file = "";
            richTextBox.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            openFileDialog.Filter = "Text file | *.txt";
            if (dialogResult == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                richTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
            file = openFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file.Equals(""))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                StreamWriter sw = new StreamWriter(file);
                sw.Write(richTextBox.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = saveFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(richTextBox.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo == true)
                richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanRedo == true)
                richTextBox.Redo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = fontDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                richTextBox.Font = fontDialog.Font;
            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.WordWrap = true;
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.WordWrap = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(about, "About CoraPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                richTextBox.ForeColor = colorDialog.Color;
            }
        }

        private void resetFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.ForeColor = default;
            richTextBox.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
        }
    }
}
