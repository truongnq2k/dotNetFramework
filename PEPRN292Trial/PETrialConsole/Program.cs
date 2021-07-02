using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PETrialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(1, "trung", "Ha Noi");
            Console.WriteLine(e.ToString());

            Employee s = new Employee();
            s.ReadFromString("2|Hung|Hai Duong");
            Console.WriteLine(s.ToString());

            EmployeeList emplist = new EmployeeList();
            emplist.ReadFromFile(@"D:\data.txt");
            emplist.Display();
            Console.ReadLine();

        }
    }
}
