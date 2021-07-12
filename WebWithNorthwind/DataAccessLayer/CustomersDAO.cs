using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class CustomersDAO
    {
        public static DataTable GetAllCustomers()
        {
            string sql = "SELECT * FROM Customers";
            return DAO.GetDataTable(sql);
        }

        public static DataTable AddNewCustomer(string cid, string cname, string cphone, string address, string city, string compa)
        {
            SqlCommand sql = new SqlCommand(@"INSERT INTO [Customers] (CustomerID, ContactName, Phone, Address, City, CompanyName) VALUES(@cid, @cname, @cphone, @address, @city, @compa)");
            sql.Parameters.AddWithValue("@cid", cid);
            sql.Parameters.AddWithValue("@cname", cname);
            sql.Parameters.AddWithValue("@cphone", cphone);
            sql.Parameters.AddWithValue("@address", address);
            sql.Parameters.AddWithValue("@city", city);
            sql.Parameters.AddWithValue("@compa", compa);
            return DAO.GetDataTable(sql);
        }
    }
}
