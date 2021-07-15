using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.DAL
{
    class CategoriesDAO
    {
        public static DataTable GetAllCategories ()
        {
            string sql = "SELECT * FROM Categories";
            return DAO.GetDataTable(sql);
        }
    }
}
