using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace IntroductionWeb.DAL
{

    class CategoryDAO
    {
        public static DataTable GetAllCategories()
        {
            string sql = "SELECT CategoryId, CategoryName FROM Categories";
            return DAO.GetDataTable(sql);
        }
    }

}
