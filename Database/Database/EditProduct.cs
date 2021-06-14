using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Database
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            
        }

        public EditProduct(string id, string name, string price, string categoryidname)
        {
            InitializeComponent();
            txtProductName.Text = name;
            txtProductPrice.Text = price;
            txtProductId.Text = id;

            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = DAO.GetAllCategory();

            comboBoxCategory.SelectedIndex = comboBoxCategory.FindStringExact(categoryidname);
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want edit ?",
            "Notification !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int pid = Convert.ToInt32(txtProductId.Text);
                double price = Convert.ToDouble(txtProductPrice.Text);
                string pname = txtProductName.Text;
                int cid = Convert.ToInt32(comboBoxCategory.SelectedValue);
                DAO.EditProduct(pid, pname, cid, price);
                MessageBox.Show("Edit Successfully!");
            }
        }


    }
}
