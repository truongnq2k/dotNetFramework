using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }

 
        public Employee()
        {
        }

        public Employee(int employeeid, string employeename, string address)
        {
            this.employeeid = employeeid;
            this.employeename = employeename;
            this.address = address;
        }


        public override string ToString()
        {
            return employeeid + " - " + employeename + " - " + address;
        }

        public void ReadFromString(string line)
        {
            string[] data = line.Split('|');
            this.employeeid = Convert.ToInt32(data[0]);
            this.employeename = data[1];
            this.address = data[2];
        }
    }
}
