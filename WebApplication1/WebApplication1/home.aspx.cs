using System;
using DemoDataAccess;
namespace WebApplication1
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
                loadDataGridView();
            }
        }
        private void loadDataGridView()
        {
            int catID = Convert.ToInt32(ddlCategory.SelectedValue);
            gvProducts.DataSource = ProductList.GetAllProductByCatID(catID);
            gvProducts.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
          
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataGridView();
        }
    }
}