using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShopManagement.DAL
{
    class CustomerDAO
    {
        public static DataTable GetAllCustomer()
        {
            string sql = "SELECT CustomerID, ContactName FROM Customers";
            return DAO.GetDataTable(sql);
        }
    }
}
