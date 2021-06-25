using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWithNorthwind
{
    public partial class listorders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCustomer.DataTextField = "ContactName";
                ddlCustomer.DataValueField = "CustomerID";
                ddlCustomer.DataSource = DataAccessLayer.CustomersDAO.GetAllCustomers();
                ddlCustomer.DataBind();

                ddlEmployee.DataTextField = "LastName";
                ddlEmployee.DataValueField = "EmployeeID";
                ddlEmployee.DataSource = DataAccessLayer.EmployeesDAO.GetAllEmployees();
                ddlEmployee.DataBind();
                
                LoadDataForDGV();
            }

        }
        private void LoadDataForDGV()
        {
            string cusID = ddlCustomer.SelectedValue;
            int empID = Convert.ToInt32(ddlEmployee.SelectedValue);


            if (!IsPostBack)
            {
                tbDateFrom.Text = "01/01/1970";
                tbDateTo.Text = DateTime.Now.ToString("dd/MM/yyyy").Replace('-', '/');
            }

            DateTime DateFrom, DateTo;

            string dFrom = tbDateFrom.Text.ToString();
            string dTo = tbDateTo.Text.ToString();

            try
            {
                DateFrom = Convert.ToDateTime(dFrom);
                DateTo = Convert.ToDateTime(dTo);
            }
            catch
            {
                DateFrom = DateTime.ParseExact("1970-01-01 00:00:00,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
                DateTo = DateTime.Now;
            }

            if (cbLateOrder.Checked)
            {
                gvProducts.DataSource = DataAccessLayer.OrdersDAO.GetAllOrdersLate(cusID, empID, DateFrom, DateTo);
            }
            else
            {
                gvProducts.DataSource = DataAccessLayer.OrdersDAO.GetAllOrders(cusID, empID, DateFrom, DateTo);
            }
            gvProducts.DataBind();

        }

        protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        protected void DateFrom_TextChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        protected void DateTo_TextChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        protected void cbLateOrder_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }
    }
}