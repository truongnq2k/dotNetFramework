using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class EmployeesDAO
    {
        public static DataTable GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
            return DAO.GetDataTable(sql);
        }
    }
}
