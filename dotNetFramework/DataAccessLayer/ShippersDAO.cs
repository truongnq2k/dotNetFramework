using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class ShippersDAO
    {
        public static DataTable GetAllShippers()
        {
            string sql = "SELECT * FROM Shippers";
            return DAO.GetDataTable(sql);
        }
    }
}
