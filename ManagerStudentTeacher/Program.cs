using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace StudentManagement
{
    class Program
    {

        public static List<Student> listStudent = new List<Student>();

        static void Main(string[] args)
        {
            StudentList list = new StudentList();
            //list.ReadFromFile(ConfigurationManager.AppSettings["InputFile"].ToString());
            //list.Display();
            list.WriteToFile(ConfigurationManager.AppSettings["OutputFile"].ToString());
            Console.ReadLine();

        }


        

        public static void display()
        {
            foreach(Student s in listStudent)
            {
                Console.WriteLine(s);
            }
        }


        public static Student getStudentByID(int studentID)
        {
            foreach (Student student in listStudent)
            {
                if (student.Id == studentID)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
