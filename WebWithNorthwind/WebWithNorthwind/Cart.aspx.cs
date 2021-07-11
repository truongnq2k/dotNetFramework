using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWithNorthwind
{
    public partial class Cart : System.Web.UI.Page
    {
        public double Total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];

            foreach(Product p in ProductList.ListProductCart(cart))
            {
                Total += p.Price;
            }

            gvCart.DataSource = ProductList.ListProductCart(cart);
            gvCart.DataBind();

            if (Convert.ToInt32(Session["quantity"]) == 0)
            {
                Response.Redirect("listproduct.aspx");
            }
        }
    }
}