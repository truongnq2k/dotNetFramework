using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
