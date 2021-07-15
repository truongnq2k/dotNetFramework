using ShopManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            cbCustomer.DisplayMember = "ContactName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = CustomerDAO.GetAllCustomer();

            cbEmployee.DisplayMember = "LastName";
            cbEmployee.ValueMember = "EmployeeID";
            cbEmployee.DataSource = EmployeeDAO.GetAllEmployee();

            cbShipper.DisplayMember = "CompanyName";
            cbShipper.ValueMember = "ShipperID";
            cbShipper.DataSource = ShipperDAO.GetAllShipper();

            //list box
            lbProducts.DataSource = ProductDAO.GetProduct();
            lbProducts.DisplayMember = "ProductName";
            lbProducts.ValueMember = "ProductID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var ListProducts = lbProducts.SelectedItems.Cast<DataRowView>();
            foreach (var item in ListProducts)
            {
                addItemToPanel(item.Row[1].ToString(), Convert.ToDouble(item.Row[2]), 1, Convert.ToInt32(item.Row[3]));
            }
        }

        private void addItemToPanel(string pname, double price, int quantity, int stock)
        {
            Panel pnItem = new Panel();
            Label lbName = new Label();
            Label lbPrice = new Label();
            TextBox tbPrice = new TextBox();
            Label lbQuantity = new Label();
            NumericUpDown nudQuantity = new NumericUpDown();

            //Name
            lbName.Text = pname;
            lbName.AutoSize = true;
            lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbName.Location = new System.Drawing.Point(5, 8);
            lbName.Name = "lbProductItemName";
            lbName.Size = new System.Drawing.Size(116, 18);
            lbName.TabIndex = 0;

            //Price
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(5, 36);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(40, 17);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";

            //Quantity
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(236, 36);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(61, 17);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Quantity";

            //Number Up Down Quantity
            nudQuantity.Location = new System.Drawing.Point(303, 34);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new System.Drawing.Size(65, 22);
            nudQuantity.TabIndex = 3;
            nudQuantity.Minimum = 0;
            nudQuantity.Maximum = stock;
            nudQuantity.Value = Convert.ToDecimal(quantity);

            //Price
            tbPrice.Location = new System.Drawing.Point(51, 34);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new System.Drawing.Size(144, 22);
            tbPrice.TabIndex = 1;
            tbPrice.Text = Convert.ToString(price);

            pnItem.Controls.Add(lbName);
            pnItem.Controls.Add(lbPrice);
            pnItem.Controls.Add(tbPrice);
            pnItem.Controls.Add(lbQuantity);
            pnItem.Controls.Add(nudQuantity);

            pnItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnItem.Location = new System.Drawing.Point(3, 3);
            pnItem.Name = "pnItem";
            pnItem.Size = new System.Drawing.Size(385, 80);
            pnItem.TabIndex = 0;

            flowLayoutPanel.Controls.Add(pnItem);
        }

        private double CalculatePrice()
        {
            return 0d;
        }
    }
}
