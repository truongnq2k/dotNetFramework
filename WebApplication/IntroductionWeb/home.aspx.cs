using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroductionWeb
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList.DataTextField = "CategoryName";
            DropDownList.DataValueField = "CategoryID";
            DropDownList.DataSource = DAL.CategoryDAO.GetAllCategories();
            DropDownList.DataBind();
        }
    }
}