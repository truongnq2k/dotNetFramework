using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWithNorthwind
{
    public partial class RemoveItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Request.QueryString["action"];
            if(action == null)
            {
                action = "";
            }

            // xoa het gio hang
            if (action.Equals("removeall"))
            {
                Dictionary<int, int> cart = new Dictionary<int, int>();
                Session["cart"] = cart;
                Session["quantity"] = 0;
            }
            // xoa san pham theo id trong gio hang
            else
            {
                try
                {
                    int pid = Convert.ToInt32(Request.QueryString["pid"]);
                    Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];
                    cart.Remove(pid);
                    Session["cart"] = cart;

                    int total = 0;
                    foreach (KeyValuePair<int, int> kvp in cart)
                    {
                        total += kvp.Value;
                    }
                    Session["quantity"] = total;
                }
                catch
                {
                    // khong lam gi ca
                }
            }
            Response.Redirect("Cart.aspx");
        }
    }
}