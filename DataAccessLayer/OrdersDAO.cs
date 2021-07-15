using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class OrdersDAO
    {
        public static DataTable GetAllOrders()
        {
            string sql = "SELECT * FROM Orders";
            return DAO.GetDataTable(sql);
        }

        public static DataTable GetAllOrders(string CusID, int EmID, DateTime DateFrom, DateTime DateTo)
        {
            SqlCommand sql = new SqlCommand("SELECT Customers.ContactName AS Customer, Employees.LastName AS Employee, Orders.OrderID, Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Orders.Freight " +
                "FROM Customers INNER JOIN " +
                "Orders ON Customers.CustomerID = Orders.CustomerID INNER JOIN " +
                "Employees ON Orders.EmployeeID = Employees.EmployeeID " +
                "WHERE Orders.CustomerID = @CusID AND Orders.EmployeeID =@EmID " +
                "AND Orders.OrderDate BETWEEN @DateFrom AND @DateTo ");
            sql.Parameters.AddWithValue("@EmID", EmID);
            sql.Parameters.AddWithValue("@CusID", CusID);
            sql.Parameters.AddWithValue("@DateFrom", DateFrom);
            sql.Parameters.AddWithValue("@DateTo", DateTo);
            return DAO.GetDataTable(sql);
        }

        public static DataTable GetAllOrdersLate(string CusID, int EmID, DateTime DateFrom, DateTime DateTo)
        {
            SqlCommand sql = new SqlCommand(@"SELECT Customers.ContactName AS Customer, Employees.LastName AS Employee, Orders.OrderID, Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Orders.Freight " +
                "FROM Customers INNER JOIN " +
                "Orders ON Customers.CustomerID = Orders.CustomerID INNER JOIN " +
                "Employees ON Orders.EmployeeID = Employees.EmployeeID " +
                "WHERE Orders.CustomerID = @CusID AND Orders.EmployeeID =@EmID AND Orders.ShippedDate > Orders.RequiredDate " +
                "AND Orders.OrderDate BETWEEN @DateFrom AND @DateTo ");
            sql.Parameters.AddWithValue("@EmID", EmID);
            sql.Parameters.AddWithValue("@CusID", CusID);
            sql.Parameters.AddWithValue("@DateFrom", DateFrom);
            sql.Parameters.AddWithValue("@DateTo", DateTo);
            return DAO.GetDataTable(sql);
        }

        public static DataTable AddNewOrder(string cid, int shipvia, double freight, string address, string city)
        {
            SqlCommand sql = new SqlCommand(@"INSERT INTO Orders (CustomerID, OrderDate, ShipVia, Freight, ShipAddress, ShipCity) " +
                "VALUES(@cid, GETDATE(), @shipvia, @freight, @address, @city) " +
                "SELECT @@IDENTITY [ODID]");
            sql.Parameters.AddWithValue("@cid", cid);
            sql.Parameters.AddWithValue("@shipvia", shipvia);
            sql.Parameters.AddWithValue("@freight", freight);
            sql.Parameters.AddWithValue("@address", address);
            sql.Parameters.AddWithValue("@city", city);
            return DAO.GetDataTable(sql);
        }

        public static void AddOrderDetail(int oid, int pid, double price, int qty, int disc)
        {
            SqlCommand sql = new SqlCommand("INSERT INTO [dbo].[Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) " +
                "VALUES(@oid, @pid, @price, @qty, @disc)");
            sql.Parameters.AddWithValue("@oid", oid);
            sql.Parameters.AddWithValue("@pid", pid);
            sql.Parameters.AddWithValue("@price", price);
            sql.Parameters.AddWithValue("@qty", qty);
            sql.Parameters.AddWithValue("@disc", disc);
            DAO.GetDataTable(sql);
        }
    }
}
