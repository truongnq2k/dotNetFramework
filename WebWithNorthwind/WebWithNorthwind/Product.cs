using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebWithNorthwind
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
    }

    class ProductList
    {
        public static List<Product> ListProductCart(Dictionary<int, int> cart)
        {
            List<Product> lp = new List<Product>();

            foreach (KeyValuePair<int, int> kvp in cart)
            {
                DataTable dt = DataAccessLayer.ProductsDAO.GetProductById(kvp.Key);

                Product p = new Product();
                p.ProductID = kvp.Key;
                p.ProductName = dt.Rows[0]["ProductName"].ToString();
                p.Quantity = kvp.Value;
                p.Price = Convert.ToDouble(dt.Rows[0]["UnitPrice"]) * kvp.Value;
                p.CategoryName = dt.Rows[0]["CategoryName"].ToString();
                lp.Add(p);
            }

            return lp;
        }

    }

}