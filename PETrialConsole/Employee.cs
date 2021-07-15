using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PETrialConsole
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }

        public Employee()
        {
        }

        public Employee(int employeeID, string employeeName, string address)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Address = address;
        }

        public override string ToString()
        {
            return EmployeeID + " - " + EmployeeName + " - " + Address;
        }

        public void ReadFromString(string line)
        {
            string[] lineArr = line.Split('|');
            EmployeeID = Convert.ToInt32(lineArr[0]);
            EmployeeName = lineArr[1];
            Address = lineArr[2];
        }
    }
}
