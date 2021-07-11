using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductsDAO
    {
        public static DataTable GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            return DAO.GetDataTable(sql);
        }  
        
        public static int GetNumberOfProduct()
        {
            string sql = "SELECT count(*) FROM Products";
            DataTable dt = DAO.GetDataTable(sql);
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public static DataTable GetProductsByPage(int start, int size)
        {
            SqlCommand sql = new SqlCommand (@"SELECT ProductID, ProductName, CategoryName, UnitPrice 
                            FROM Products P, Categories C
                            WHERE P.CategoryID = C.CategoryID 
                            ORDER BY ProductName
                            OFFSET @start ROWS
                            FETCH NEXT @size ROWS ONLY");
            sql.Parameters.AddWithValue("@start", start);
            sql.Parameters.AddWithValue("@size", size);
            return DAO.GetDataTable(sql);
        }

        public static DataTable GetProductById(int pid)
        {
            SqlCommand sql = new SqlCommand(@"SELECT ProductID, ProductName, CategoryName, UnitPrice 
                            FROM Products P, Categories C
                            WHERE P.CategoryID = C.CategoryID AND ProductID = @pid
                            ORDER BY ProductName");
            sql.Parameters.AddWithValue("@pid", pid);
            return DAO.GetDataTable(sql);
        }
    }
}
