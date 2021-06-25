using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DemoDataAccess;

namespace FirstWebApp
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(Request.QueryString["pid"]);
            int CategoryID = Convert.ToInt32(Request.QueryString["cid"]);
            //delete product;
            Response.Redirect("home.aspx?cid=" + CategoryID.ToString());
        }
    }
}