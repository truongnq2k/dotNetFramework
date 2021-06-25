using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ProductsDAO
    {
        public static DataTable GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            return DAO.GetDataTable(sql);
        }   
    }
}
