using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PETrialWebforms
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataTextField = "CompanyName";
            DropDownList1.DataValueField = "SupplierID";
            DropDownList1.DataSource = SupplierDAO.getAllSupplier();
            DropDownList1.DataBind();

            DropDownList2.DataTextField = "CategoryName";
            DropDownList2.DataValueField = "CategoryID";
            DropDownList2.DataSource = CategoryDAO.getAllCategory();
            DropDownList2.DataBind();
        }
    }
}