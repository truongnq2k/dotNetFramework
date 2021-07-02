using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PETrialWinforms
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private List<int> ListAllCheckedBox = new List<int>();
        private List<int> ListIndexCheckedBox = new List<int>();


        private void Form_Load(object sender, EventArgs e)
        {
            checkedListBoxDisplay();
            dataGridViewDisplay(ListAllCheckedBox);
        }

        private void checkedListBoxDisplay()
        {
            DataTable dataSet = DAL.ProductDAO.GetAllProduct();
            int i = 0;
            foreach (DataColumn column in dataSet.Columns)
            {
                checkedListBox.Items.Add(column.ColumnName);
                ListAllCheckedBox.Add(i++);
            }
        }

        private void dataGridViewDisplay(List<int> index)
        {
            // clear all data
            dataGridView.Columns.Clear();
            // disable add row from user
            dataGridView.AllowUserToAddRows = false;
            // disable auto generate column
            dataGridView.AutoGenerateColumns = false;

            foreach (int id in index)
            {
                if(id == 0)
                {
                    dataGridView.Columns.Add("0", "ProductID");
                    dataGridView.Columns["0"].DataPropertyName = "ProductID";
                }
                if (id == 1)
                {
                    dataGridView.Columns.Add("1", "ProductName");
                    dataGridView.Columns["1"].DataPropertyName = "ProductName";
                }
                if (id == 2)
                {
                    dataGridView.Columns.Add("2", "CompanyName");
                    dataGridView.Columns["2"].DataPropertyName = "CompanyName";
                }
                if (id == 3)
                {
                    dataGridView.Columns.Add("3", "CategoryName");
                    dataGridView.Columns["3"].DataPropertyName = "CategoryName";
                }
                if (id == 4)
                {
                    dataGridView.Columns.Add("4", "QuantityPerUnit");
                    dataGridView.Columns["4"].DataPropertyName = "QuantityPerUnit";
                }
                if (id == 5)
                {
                    dataGridView.Columns.Add("5", "UnitPrice");
                    dataGridView.Columns["5"].DataPropertyName = "UnitPrice";
                }
                if (id == 6)
                {
                    dataGridView.Columns.Add("6", "UnitsInStock");
                    dataGridView.Columns["6"].DataPropertyName = "UnitsInStock";
                }
                if (id == 7)
                {
                    dataGridView.Columns.Add("7", "UnitsOnOrder");
                    dataGridView.Columns["7"].DataPropertyName = "UnitsOnOrder";
                }
                if (id == 8)
                {
                    dataGridView.Columns.Add("8", "ReorderLevel");
                    dataGridView.Columns["8"].DataPropertyName = "ReorderLevel";
                }
                if (id == 9)
                {
                    dataGridView.Columns.Add("9", "Discontinued");
                    dataGridView.Columns["9"].DataPropertyName = "Discontinued";
                }
            }
            dataGridView.DataSource = DAL.ProductDAO.GetAllProduct();
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
            {
                foreach(int i in ListAllCheckedBox)
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
            else if(ListIndexCheckedBox.Count != ListAllCheckedBox.Count)
            {
                foreach (int i in ListAllCheckedBox)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
                foreach (int i in ListIndexCheckedBox)
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
            else
            {
                foreach (int i in ListAllCheckedBox)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
                checkedListBox.SetItemChecked(0, true);
                checkedListBox.SetItemChecked(1, true);
            }
        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListIndexCheckedBox = new List<int>();
            foreach (int indexChecked in checkedListBox.CheckedIndices)
            {
                ListIndexCheckedBox.Add(indexChecked);
            }
            dataGridViewDisplay(ListIndexCheckedBox);
            if (ListIndexCheckedBox.Count == ListAllCheckedBox.Count)
            {
                checkBoxSelectAll.Checked = true;
            }
            else
            {
                checkBoxSelectAll.Checked = false;
            }
        }
    }
}
