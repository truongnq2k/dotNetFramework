using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace DemoDataAccess
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }

        public Product()
        {
        }

        public Product(int productID, string productName, double price, int categoryID, string categoryName)
        {
            ProductID = productID;
            ProductName = productName;
            Price = price;
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
        public static int DeleteProduct(int ProductID)
        {
            return DAO.DeleteProduct(ProductID);
        }
        public static int Update(int ProductID, string Pname, string Price, string catID)
        {
            return DAO.UpdateProduct(ProductID, Pname, Price, catID);
        }
     
    }
    public class ProductList
    {
        public static List<Product> GetAllProductByCatID(int CatID)
        {
            List<Product> cats = new List<Product>();
            DataTable dt = DAO.GetProductByCatIDUsingSP(CatID);
            foreach (DataRow dr in dt.Rows)
                cats.Add(new Product(
                    Convert.ToInt32(dr["ProductID"]),
                    dr["ProductName"].ToString(),
                    Convert.ToDouble(dr["UnitPrice"]),
                    Convert.ToInt32(dr["CategoryID"]),
                    dr["CategoryName"].ToString()
                    ));
            return cats;
            //return DAO.GetProductByCatIDUsingSP(CatID);
        }
    }
}
