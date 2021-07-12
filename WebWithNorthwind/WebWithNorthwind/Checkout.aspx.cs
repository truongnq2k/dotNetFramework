using DataAccessLayer;
using LibraryDonViHanhChinh;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebWithNorthwind
{
    public partial class Checkout : System.Web.UI.Page
    {
        public double Total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProvince.DataTextField = "name";
                ddlProvince.DataValueField = "id";
                ddlProvince.DataSource = ProvinceDAO.GetAllProvince();
                ddlProvince.DataBind();

                ddlDistrict.Items.Clear();
                ddlDistrict.Items.Add("--Select District--");
                ddlDistrict.DataTextField = "name";
                ddlDistrict.DataValueField = "id";
                ddlDistrict.DataSource = DistrictDAO.GetDisctrictByProvinceID(Convert.ToInt32(ddlProvince.SelectedItem.Value));
                ddlDistrict.DataBind();

                ddlWard.Items.Clear();
                ddlWard.Items.Add("--Select District--");
                ddlWard.DataTextField = "name";
                ddlWard.DataValueField = "id";
                ddlWard.DataSource = WardDAO.GetWardByDisctrictID(Convert.ToInt32(ddlDistrict.SelectedItem.Value));
                ddlWard.DataBind();

                ddlShipping.DataTextField = "CompanyName";
                ddlShipping.DataValueField = "ShipperID";
                ddlShipping.DataSource = DataAccessLayer.ShippersDAO.GetAllShippers();
                ddlShipping.DataBind();
            }
            BindingRepeaterProduct();
        }

        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlDistrict.Items.Clear();
            ddlDistrict.Items.Add("--Select District--");
            ddlDistrict.DataTextField = "name";
            ddlDistrict.DataValueField = "id";
            ddlDistrict.DataSource = DistrictDAO.GetDisctrictByProvinceID(Convert.ToInt32(ddlProvince.SelectedItem.Value));
            ddlDistrict.DataBind();
        }
        protected void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlWard.Items.Clear();
            ddlWard.Items.Add("--Select Ward--");
            ddlWard.DataTextField = "name";
            ddlWard.DataValueField = "id";
            ddlWard.DataSource = WardDAO.GetWardByDisctrictID(Convert.ToInt32(ddlDistrict.SelectedItem.Value));
            ddlWard.DataBind();
        }

        protected void BindingRepeaterProduct()
        {
            Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];
            foreach (Product p in ProductList.ListProductCart(cart))
            {
                Total += p.Price;
            }
            rpProduct.DataSource = ProductList.ListProductCart(cart);
            rpProduct.DataBind();
        }

        protected void Checkout_Click(object sender, EventArgs e)
        {
            string name = fullName.Text;
            string phone = contactPhone.Text;
            string address = caddress.Text;
            string city = ddlProvince.SelectedItem.Text;
            string company = contactCompany.Text;
            int ship = Convert.ToInt32(ddlShipping.SelectedItem.Value);


            Dictionary<int, int> cart = (Dictionary<int, int>)Session["cart"];
            foreach (Product p in ProductList.ListProductCart(cart))
            {
                Total += p.Price;
            }

            //RANDOM CUSTOMERID
            int length = 5;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }

            string cid = str_build.ToString();

            CustomersDAO.AddNewCustomer(cid, name, phone, address, city, company);
            DataTable dto = OrdersDAO.AddNewOrder(cid, ship, Total, address, city);

            int oid = Convert.ToInt32(dto.Rows[0]["ODID"]);

            foreach (Product p in ProductList.ListProductCart(cart))
            {
                OrdersDAO.AddOrderDetail(oid, p.ProductID, p.Price, p.Quantity, 0);
            }

            // Remove data in session
            Dictionary<int, int> cart1 = new Dictionary<int, int>();
            Session["cart"] = cart1;
            Session["quantity"] = 0;

            Response.Redirect("listproduct.aspx");
        }
    }
}