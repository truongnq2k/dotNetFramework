using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IntroductionWeb.DAL
{
    class ShipperDAO
    {
        public static DataTable GetAllShipper()
        {
            string sql = @"SELECT ShipperID, CompanyName FROM Shippers";
            return DAO.GetDataTable(sql);
        }   
    }
}
