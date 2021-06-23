using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DemoDataAccess
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["NorthwindConStr"].ToString();
            return new SqlConnection(conStr);
        }

        public static DataTable GetDataBySql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetDataBySqlwithParameter(string sql,params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetProducsByCatID(int CatID)
        {
            string sql = @"select ProductID,ProductName,C.CategoryID,CategoryName,UnitPrice 
                        from Products P , Categories C                
                        where P.CategoryID=C.CategoryID and P.CategoryID = @cid";
            SqlParameter parameter = new SqlParameter("@cid", SqlDbType.Int);
            parameter.Value = CatID;
            return GetDataBySqlwithParameter(sql, parameter);
        }
     
        public static DataTable GetDataByStoredProcedure(string SpName, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(SpName, GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static int ExecuteSQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
       
        public static int DeleteProduct(int ProductID)
        {
            DeleteOrderDetails(ProductID);
            string sql = "delete from Products where ProductID = @pid";
            SqlParameter parameters = new SqlParameter("@pid", SqlDbType.Int);
            parameters.Value = ProductID;
            return ExecuteSQL(sql, parameters);
        }
        public static int DeleteOrderDetails(int ProductID)
        {
            string sql = "delete from [Order Details] where ProductID = @pid";
            SqlParameter param = new SqlParameter("@pid", SqlDbType.Int);
            param.Value = ProductID;
            return ExecuteSQL(sql, param);
        }
        public static DataTable GetAllCategories()
        {
            string sql = "select * from Categories";
            return GetDataBySql(sql);
        }

        public static DataTable GetProductByCatIDUsingSP(int CatID)
        {
            SqlParameter parameter = new SqlParameter("@cid", SqlDbType.Int);
            parameter.Value = CatID;
            return GetDataByStoredProcedure("GetAllProductByCatID",parameter);
        }
        public static int UpdateProduct(int ProductID, string Pname, string Price, string catID)
        {
            int check = -1;
            SqlConnection con = GetConnection();
            string sql = "Update Products set ProductName ='" + Pname + "' ,UnitPrice = " + Price + ", CategoryID =" + catID + "where ProductID = " + ProductID;
            con.Open();
            try
            {

                SqlCommand sc = new SqlCommand(sql, con);
                check = sc.ExecuteNonQuery();
            }
            catch (Exception)
            {
                check = 0;
            }
            con.Close();
            return check;
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
        public static void UpdateProduct(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
        }
    }
}
