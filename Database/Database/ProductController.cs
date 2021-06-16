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
    public partial class ProductController : Form
    {
        public ProductController()
        {
            InitializeComponent();
        }

        private void ProductController_Load(object sender, EventArgs e)
        {
            // disable add row from user
            dataGridView.AllowUserToAddRows = false;
            // disable auto generate column
            dataGridView.AutoGenerateColumns = false;

            // add check box in first column
            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            checkBox.Name = "Select";
            dataGridView.Columns.Add(checkBox);

            dataGridView.Columns.Add("ProductId", "PID");
            dataGridView.Columns["ProductId"].DataPropertyName = "ProductId";

            dataGridView.Columns.Add("ProductName", "Product Name");
            dataGridView.Columns["ProductName"].DataPropertyName = "ProductName";

            dataGridView.Columns.Add("CategoryName", "Category");
            dataGridView.Columns["CategoryName"].DataPropertyName = "CategoryName";

            dataGridView.Columns.Add("UnitPrice", "Price");
            dataGridView.Columns["UnitPrice"].DataPropertyName = "UnitPrice";

            //add column edit
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Action";
            editButton.Name = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(editButton);

            //load category
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = DAO.GetAllCategory();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
            dataGridView.DataSource = DAO.GetProductsByCategoryId(CategoryId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to delete?",
            "Notification !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                foreach (DataGridViewRow rowGrid in dataGridView.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = rowGrid.Cells[0] as DataGridViewCheckBoxCell;
                    DataGridViewCell cell = rowGrid.Cells[1];
                    if (Convert.ToBoolean(checkBoxCell.Value) == true)
                    {
                        int pid = Convert.ToInt32(cell.Value);
                        DAO.DeleteProductById(pid);
                    }
                }
            }
            int CatID = Convert.ToInt32(comboBoxCategory.SelectedValue);
            dataGridView.DataSource = DAO.GetProductsByCategoryId(CatID);

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {
                DataTable products = (DataTable)dataGridView.DataSource;
                EditProduct editForm = new EditProduct(products.Rows[e.RowIndex][0].ToString(), products.Rows[e.RowIndex][1].ToString(), products.Rows[e.RowIndex][4].ToString(), products.Rows[e.RowIndex][3].ToString());
                editForm.FormClosed += EditFormClosed;
                editForm.Show();
            }
        }

        private void EditFormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Notification !", "You want closed FORM?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
                dataGridView.DataSource = DAO.GetProductsByCategoryId(CategoryId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertProduct insertForm = new InsertProduct();
            insertForm.FormClosed += EditFormClosed;
            insertForm.Show();
        }
    }
}
