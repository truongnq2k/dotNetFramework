using ShopManagement.DAL;
using ShopManagement.Entity;
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
    public partial class ListOrder : Form
    {

        private string CustomerID;
        private int EmployeeID;
        private DateTime DateFrom, DateTo;

        public ListOrder()
        {
            InitializeComponent();
        }

        private void ListOrder_Load(object sender, EventArgs e)
        {
            // disable add row from user
            dataGridView.AllowUserToAddRows = false;
            // disable auto generate column
            dataGridView.AutoGenerateColumns = false;

            cbCustomer.DisplayMember = "ContactName";
            cbCustomer.ValueMember = "CustomerID";
            cbCustomer.DataSource = CustomerDAO.GetAllCustomer();

            cbEmployee.DisplayMember = "LastName";
            cbEmployee.ValueMember = "EmployeeID";
            cbEmployee.DataSource = EmployeeDAO.GetAllEmployee();

            dtpFrom.Value = DateTime.ParseExact("1900-01-01 00:00:00,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
            dtpTo.Value = DateTime.Now;

            dataGridView.Columns.Add("oid", "OrderId");
            dataGridView.Columns["oid"].DataPropertyName = "OrderID";

            dataGridView.Columns.Add("cus", "Customer");
            dataGridView.Columns["cus"].DataPropertyName = "ContactName";

            dataGridView.Columns.Add("emp", "Employee");
            dataGridView.Columns["emp"].DataPropertyName = "LastName";

            dataGridView.Columns.Add("odate", "Order Date");
            dataGridView.Columns["odate"].DataPropertyName = "OrderDate";

            dataGridView.Columns.Add("rdate", "Required Date");
            dataGridView.Columns["rdate"].DataPropertyName = "RequiredDate";

            dataGridView.Columns.Add("sdate", "Shipped Date");
            dataGridView.Columns["sdate"].DataPropertyName = "ShippedDate";

            dataGridView.Columns.Add("fre", "Freight");
            dataGridView.Columns["fre"].DataPropertyName = "Freight";


            //ChangeGridView(sender, e);

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeGridView(sender, e);
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeGridView(sender, e);
        }

        private void cbLateOrder_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGridView(sender, e);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            ChangeGridView(sender, e);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            ChangeGridView(sender, e);
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            AddOrder addform = new AddOrder();
            addform.FormClosed += ExitFormClosed;
            addform.Show();
        }

        private void ChangeGridView(object sender, EventArgs e)
        {
            DateFrom = dtpFrom.Value;
            DateTo = dtpTo.Value;
            CustomerID = cbCustomer.SelectedValue.ToString();
            EmployeeID = Convert.ToInt32(cbEmployee.SelectedValue);
            if (cbLateOrder.Checked)
            {
                dataGridView.DataSource = DAL.OrderDAO.GetAllOrdersLate(CustomerID, EmployeeID, DateFrom, DateTo);
            }
            else
            {
                dataGridView.DataSource = DAL.OrderDAO.GetAllOrders(CustomerID, EmployeeID, DateFrom, DateTo);
            }
        }


        private void ExitFormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("You want close?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ChangeGridView(sender, e);
            }
        }
    }
}
