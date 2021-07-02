using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PETrialWebforms
{
    public class SupplierDAO
    {
        public static DataTable getAllSupplier()
        {
            string sql = @"SELECT SupplierID, CompanyName FROM Suppliers";
            return DAO.GetDataTable(sql);
        }
    }
}