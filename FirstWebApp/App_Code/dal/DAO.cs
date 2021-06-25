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

        public static DataTable GetDataBySqlWithParameters(string sql,params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
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

        public static DataTable GetProductsByCatID(int CatID)
        {
            string sql = @"select ProductID, ProductName, C.CategoryID, CategoryName, UnitPrice 
                            from Products P, Categories C
                            where P.CategoryID = C.CategoryID and P.CategoryID = @cid";
            SqlParameter parameter = new SqlParameter("@cid", SqlDbType.Int);
            parameter.Value = CatID;
            return GetDataBySqlWithParameters(sql, parameter);
        }

        public static DataTable GetAllCategories()
        {
            string sql = "select CategoryID, CategoryName from Categories";
            return GetDataBySql(sql);
        }

        public static DataTable GetAllCustomer()
        {
            string sql = "select CustomerID, CompanyName from Customers";
            return GetDataBySql(sql);
        }

        public static DataTable GetAllShipper()
        {
            string sql = "select ShipperID, CompanyName from Shippers";
            return GetDataBySql(sql);
        }

        public static DataTable GetAllEmployee()
        {
            string sql = "select EmployeeID, FirstName + ' ' + LastName [EmployeeName] from Employees";
            return GetDataBySql(sql);
        }

        public static DataTable GetAllProduct()
        {
            string sql = "select ProductID, ProductName, UnitPrice, C.CategoryID, C.CategoryName from Products P, Categories C where P.CategoryID = C.CategoryID";
            return GetDataBySql(sql);
        }

        public static DataTable GetProductsByCatIDUsingSP(int CatID)
        {
            SqlParameter parameter = new SqlParameter("@cid", SqlDbType.Int);
            parameter.Value = CatID;
            return GetDataBySqlWithParameters("GetAllProductByCatID", parameter);
        }

        public static int ExecuteSqlWithParameters(string sql, SqlParameter[] parameters)
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
            string sql = "delete from [Order Details] where ProductID = @pid";
            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter("@pid", SqlDbType.Int);
            paras[0].Value = ProductID;
            ExecuteSqlWithParameters(sql, paras);

            sql = "delete from Products where ProductID = @pid";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = ProductID;
            return ExecuteSqlWithParameters(sql, parameters);
        }

        public static int UpdateProduct(int ProductID, string ProductName, int CategoryID, double Price)
        {
            string sql = @"update Products set ProductName = @pname, CategoryID = @catid, UnitPrice=@price 
                        where ProductID = @pid";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@pid", SqlDbType.Int);
            parameters[0].Value = ProductID;
            parameters[1] = new SqlParameter("@pname", SqlDbType.NVarChar);
            parameters[1].Value = ProductName;
            parameters[2] = new SqlParameter("@catid", SqlDbType.Int);
            parameters[2].Value = CategoryID;
            parameters[3] = new SqlParameter("@price", SqlDbType.Money);
            parameters[3].Value = Price;
            return ExecuteSqlWithParameters(sql, parameters);
        }

        public static int DeleteOrder(int OrderID)
        {
            string sql = @"delete from [Order Details] where OrderID = @oid";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@oid", SqlDbType.Int);
            parameters[0].Value = OrderID;
            ExecuteSqlWithParameters(sql, parameters);

            sql = @"delete from [Orders] where OrderID = @oid";
            SqlParameter[] parameters1 = new SqlParameter[1];
            parameters1[0] = new SqlParameter("@oid", SqlDbType.Int);
            parameters1[0].Value = OrderID;
            return ExecuteSqlWithParameters(sql, parameters1);
        }

        //CustomerID = 'All' -> Chon Order cua All Customer
        //EmployeeID = 0 -> Chon Order cua All Employee
        public static DataTable GetOrders(string CustomerID, int EmployeeID, DateTime FromDate, DateTime ToDate, Boolean LateOrder)
        {
            string sql = @"select OrderID, OrderDate, RequiredDate, ShippedDate, C.CompanyName, E.FirstName + ' ' + E.LastName [EmployeeName]
                            from Orders O, Customers C, Employees E
                            where O.CustomerID = C.CustomerID and E.EmployeeID = O.EmployeeID and
                                CONVERT(Date, OrderDate) between CONVERT(Date,@from) and CONVERT(Date,@to) ";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@from", SqlDbType.DateTime));
            parameters[0].Value = FromDate;
            parameters.Add( new SqlParameter("@to", SqlDbType.DateTime));
            parameters[1].Value = ToDate;

            if (!CustomerID.Equals("All"))
            {
                sql += " and C.CustomerID = @cus ";
                SqlParameter param = new SqlParameter("@cus", SqlDbType.VarChar);
                param.Value = CustomerID;
                parameters.Add(param);
            }

            if (EmployeeID != 0)
            {
                sql += " and E.EmployeeID = @emp ";
                SqlParameter param = new SqlParameter("@emp", SqlDbType.Int);
                param.Value = EmployeeID;
                parameters.Add(param);
            }

            if (LateOrder)
                sql += " and ShippedDate > RequiredDate ";
            return GetDataBySqlWithParameters(sql, parameters.ToArray());            
        }
    }
}
