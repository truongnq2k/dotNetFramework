using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoDataAccess;

namespace FirstWebApp
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryID";
                ddlCategory.DataSource = CategoryList.GetAllCategory();
                ddlCategory.DataBind();
                LoadDataForDGV();
            }
           
        }

        private void LoadDataForDGV()
        {
            int catID = Convert.ToInt32(ddlCategory.SelectedValue);
            gvProducts.DataSource = ProductList.GetProductsByCatID(catID);
            gvProducts.DataBind();
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataForDGV();
        }

        protected void gvProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}