using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoDataAccess
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Product(int productID, string productName, double price, int categoryID, string categoryName)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

        public static int UpdateProduct(int ProductID, string ProductName, int CategoryID, double Price)
        {
            return DAO.UpdateProduct(ProductID, ProductName, CategoryID, Price);
        }
    }

    class ProductList
    {
        public static List<Product> GetProductsByCatID(int CatID)
        {
            List<Product> products = new List<Product>();
            DataTable dt = DAO.GetProductsByCatID(CatID);
            foreach(DataRow dr in dt.Rows)
            {
                Product p = new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    Convert.ToDouble (dr["UnitPrice"]),
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    ) ;
                products.Add(p);
            }
            return products;
        }

        public static List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();
            DataTable dt = DAO.GetAllProduct();
            foreach (DataRow dr in dt.Rows)
            {
                Product p = new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    );
                products.Add(p);
            }
            return products;
        }


    }
}
