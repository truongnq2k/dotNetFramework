using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IntroductionWeb.DAL
{
    class EmployeeDAO
    {
        public static DataTable GetAllEmployee()
        {
            string sql = "SELECT EmployeeID, LastName FROM Employees";
            return DAO.GetDataTable(sql);
        }
    }
}
