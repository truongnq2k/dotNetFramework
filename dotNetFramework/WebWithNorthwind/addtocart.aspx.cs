using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWithNorthwind
{
    public partial class addtocart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Count quantity in cart
                int count = Convert.ToInt32(Session["quantity"]);

                string Page = Request.QueryString["page"];
                int ProductID = Convert.ToInt32(Request.QueryString["pid"]);

                Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];
                
                if (cart.ContainsKey(ProductID))
                {
                    cart[ProductID]++;
                    count++;
                }
                else
                {
                    cart.Add(ProductID, 1);
                    count++;
                }
                Session["cart"] = cart;

                Session["quantity"] = count;

                Response.Redirect("listproduct.aspx?page=" + Page);
            }
            catch
            {

            }
        }
    }
}