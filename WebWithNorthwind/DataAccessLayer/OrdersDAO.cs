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
    }
}
