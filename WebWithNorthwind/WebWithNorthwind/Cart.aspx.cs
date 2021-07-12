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

            rpProduct.DataSource = ProductList.ListProductCart(cart);
            rpProduct.DataBind();

            if (Convert.ToInt32(Session["quantity"]) == 0)
            {
                Response.Redirect("listproduct.aspx");
            }
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            //Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];
            //cart.Remove(pid);
            //Session["cart"] = cart;

            //int total = 0;
            //foreach (KeyValuePair<int, int> kvp in cart)
            //{
            //    total += kvp.Value;
            //}
            //Total = total;
            //Session["quantity"] = Total;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];
            //cart.Remove(pid);
            //Session["cart"] = cart;

            //int total = 0;
            //foreach (KeyValuePair<int, int> kvp in cart)
            //{
            //    total += kvp.Value;
            //}
            //Total = total;
            //Session["quantity"] = Total;
        }
    }
}