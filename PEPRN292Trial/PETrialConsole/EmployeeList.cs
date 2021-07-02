using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PETrialConsole
{
    class EmployeeList
    {
        private static FileStream fs;

        private List<Employee> employees = new List<Employee>();

        public void ReadFromFile(string FileName)
        {
            //phai co file moi doc duoc
            if (File.Exists(FileName))
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Employee e = new Employee();
                    e.ReadFromString(str);
                    employees.Add(e);
                    str = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            else
            {
                Console.WriteLine("File doesn't exist!");
            }
        }

        public void Display()
        {
            Console.WriteLine("Number Of Employees in the input file: {0}", employees.Count);
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
