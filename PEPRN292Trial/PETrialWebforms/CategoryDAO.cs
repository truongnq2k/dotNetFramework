using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PETrialWebforms
{
    public class CategoryDAO
    {
        public static DataTable getAllCategory()
        {
            string sql = @"SELECT CategoryID, CategoryName FROM Categories";
            return DAO.GetDataTable(sql);
        }
    }
}