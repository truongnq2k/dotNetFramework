using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IntroductionWeb.DAL
{
    class ProductDAO
    {
        public static DataTable GetProduct()
        {
            string sql = @"SELECT ProductID , ProductName, UnitPrice, UnitsInStock FROM Products WHERE UnitsInStock > 0";
            return DAO.GetDataTable(sql);
        }
    }
}
