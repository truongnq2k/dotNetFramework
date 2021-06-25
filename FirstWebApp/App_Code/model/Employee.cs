using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoDataAccess
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public Employee(int EmployeeID, string EmployeeName)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeeName = EmployeeName;
        }

    }

    class EmployeeList
    {
        public static List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>();
            DataTable dt = DAO.GetAllEmployee();
            foreach (DataRow dr in dt.Rows)
            {
                Employee c = new Employee(
                    Convert.ToInt32(dr["EmployeeID"]),
                    dr["EmployeeName"].ToString()
                    );
                employees.Add(c);
            }
            return employees;
        }

        public static List<Employee> GetAllEmployeeWithItemAll()
        {
            List<Employee> employees = GetAllEmployee();
            employees.Insert(0, new Employee(0, "All Employee"));
            return employees;
        }
    }
}
