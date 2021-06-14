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
    public partial class InsertProduct : Form
    {
        public InsertProduct()
        {
            InitializeComponent();
        }

        private void InsertProduct_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = DAO.GetAllCategory();
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string pname = txtProductName.Text;
            double price = Convert.ToDouble(txtProductPrice.Text);
            int cid = Convert.ToInt32(comboBoxCategory.SelectedValue);
            DAO.InsertProduct(pname, cid, price);
            MessageBox.Show("Insert Successfully!");
        }
    }
}
