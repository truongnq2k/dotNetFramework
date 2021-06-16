using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Database
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            //"server=localhost; database=Northwind; user=sa; password=123456";
            string conStr = ConfigurationManager.ConnectionStrings["NorthWind"].ToString();
            return new SqlConnection(conStr);
        }

        public static DataTable GetDataBySqlWithParameters(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static void UpdateProduct(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
        }

        public static DataTable GetProductsByCategoryId(int CategoryId)
        {
            string sql = @"SELECT ProductId, ProductName, C.CategoryId, CategoryName, UnitPrice 
                            FROM Products P, Categories C
                            WHERE P.CategoryId = C.CategoryId AND P.CategoryId = @cid";
            SqlParameter parameter = new SqlParameter("@cid", SqlDbType.Int);
            parameter.Value = CategoryId;
            return GetDataBySqlWithParameters(sql, parameter);
        }

        public static DataTable GetAllCategory()
        {
            string sql = "SELECT CategoryId, CategoryName FROM Categories";
            return GetDataBySqlWithParameters(sql);
        }

        public static void DeleteProductById(int ProductId)
        {
            string sql = @"DELETE FROM [Order Details] WHERE ProductID = @pid DELETE FROM Products WHERE ProductId = @pid";
            SqlParameter parameter = new SqlParameter("@pid", ProductId);
            parameter.Value = ProductId;
            UpdateProduct(sql, parameter);
        }


        public static void EditProduct(int ProductId, string ProductName, int CategoryId, double Price)
        {
            string sql = @"UPDATE Products SET  ProductName = @pname, CategoryId = @cid, UnitPrice = @uprice WHERE ProductID = @pid";
            SqlParameter p1 = new SqlParameter("@pname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@cid", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@uprice", SqlDbType.Money);
            SqlParameter p4 = new SqlParameter("@pid", SqlDbType.Int);
            p1.Value = ProductName;
            p2.Value = CategoryId;
            p3.Value = Price;
            p4.Value = ProductId;
            UpdateProduct(sql, p1, p2, p3, p4);
        }

        public static void InsertProduct(string ProductName, int CategoryId, double Price)
        {
            string sql = "INSERT INTO Products (ProductName, CategoryID, UnitPrice) VALUES(@pname, @cid, @uprice)";
            SqlParameter p1 = new SqlParameter("@pname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@cid", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@uprice", SqlDbType.Money);
            p1.Value = ProductName;
            p2.Value = CategoryId;
            p3.Value = Price;
            UpdateProduct(sql, p1, p2, p3);
        }





    }
}
