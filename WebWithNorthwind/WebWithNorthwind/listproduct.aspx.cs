using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebWithNorthwind.App_Code.Model;

namespace WebWithNorthwind
{
    public partial class listproduct : System.Web.UI.Page
    {
        public double Total = 0;
        public int PageIndex = 1, CartQuantity = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // lay so luong san pham trong gio hang
                try
                {
                    CartQuantity = Convert.ToInt32(Session["quantity"]);
                }
                catch
                {
                    CartQuantity = 0;
                }

                int PageSize, NumberOfPage;
                try
                {
                    // lay param tu url
                    PageIndex = (Request.QueryString["page"] != null) ? Convert.ToInt32(Request.QueryString["page"]) : 1;
                }
                catch (FormatException)
                {
                    Response.Redirect("listproduct.aspx");
                }

                // So bai tren 1 trang
                PageSize = Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);

                // Cong thuc tinh so trang
                NumberOfPage = (ProductsDAO.GetNumberOfProduct() - 1) / PageSize + 1;

                if (PageIndex > NumberOfPage)
                {
                    PageIndex = NumberOfPage;
                }

                if (NumberOfPage > 1)
                {
                    Pagination(PageIndex, PageSize, NumberOfPage);
                }

                int start = (PageIndex - 1) * PageSize;

                gvProducts.DataSource = ProductsDAO.GetProductsByPage(start, PageSize);
                gvProducts.DataBind();


            }


            // OFF CANVAS SHOW CART
            Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];

            foreach (Product p in ProductList.ListProductCart(cart))
            {
                Total += p.Price;
            }

            gvCart.DataSource = ProductList.ListProductCart(cart);
            gvCart.DataBind();


        }

        private void Pagination(int PageIndex, int PageSize, int NumberOfPage)
        {
            List<PageItem> pages = new List<PageItem>();

            for (int i = 1; i <= NumberOfPage; i++)
            {
                PageItem pageItem = new PageItem();
                pageItem.CssClass = "";
                pageItem.TextColor = "text-dark";
                pageItem.BGButton = "";
                pageItem.PageNumber = i;
                pages.Add(pageItem);
            }

            pages[PageIndex - 1].CssClass = "active";
            pages[PageIndex - 1].TextColor = "text-white";
            pages[PageIndex - 1].BGButton = "bg-success";

            rpPages.DataSource = pages;
            rpPages.DataBind();
        }
    }
}