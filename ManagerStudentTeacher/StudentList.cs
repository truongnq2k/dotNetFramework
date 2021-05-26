using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace StudentManagement
{
    class StudentList
    {
        List<Student> listStudent = new List<Student>();
        public StudentList()
        {
            listStudent = new List<Student>();
        }

        public void Input()
        {
            while (AddStudent());
        }

        public bool AddStudent()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Input student. Choose one of below");
            Console.WriteLine("1 add Student: ");
            Console.WriteLine("2 add Foreign Student: ");
            Console.WriteLine("3 add Vietnamese student: ");
            Console.WriteLine("4 to exit: ");
            Console.WriteLine("=============================");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Student student = new Student();
                    student.Input();
                    listStudent.Add(student);
                    return true;
                case 2:
                    Student foreignStudent = new ForeignStudent();
                    foreignStudent.Input();
                    listStudent.Add(foreignStudent);
                    return true;
                case 3:
                    Student vietnameseStudent = new VNStudent();
                    vietnameseStudent.Input();
                    listStudent.Add(vietnameseStudent);
                    return true;
                default:
                    return false;
            }
        }

        public void InitData()
        {
            //listStudent.Add(new Student(1, "trung", "12 Dec 2000"));
            //listStudent.Add(new ForeignStudent(20, "john", "12 Dec 2001", "us"));
            //listStudent.Add(new VNStudent(12345, 6, "hoang", "12 Dec 2000"));
            //listStudent.Add(new Student(1, "trung", "12 Dec 2000"));
            //listStudent.Add(new ForeignStudent(2, "john", "12 Dec 2002", "uk"));
            //listStudent.Add(new VNStudent(54321, 3, "thao", "12 Dec 2000"));
        }

        public void Display()
        {
            foreach (Student s in listStudent) 
                Console.WriteLine(s);
        }

        public int SearchByID(int id) //tim s o vi tri co index bao nhieu trong ds
        {
            Student s = new Student(id);
            return listStudent.IndexOf(s);
        }

        public void SearchByID()
        {
            Console.WriteLine("Input ID:");
            int ID = Convert.ToInt32(Console.ReadLine());
            int index = SearchByID(ID);
            if (index < 0) Console.WriteLine("ID nay khong co trong ds");
            else Console.WriteLine("ID co trong trong dssv tai vi tri: " + index);
        }

        public void Sort()
        {
            listStudent.Sort();
        }

        //public static int StuCompareByName(Student s1, Student s2)
        //{
        //    return s1.Name.CompareTo(s2.Name);
        //}
        public void SortByName()
        {
            //Rut gon 1: Khong dinh nghia ham tuong minh StuCompareByName, dung anonmyous function
            //listStudent.Sort(
            //    delegate (Student s1, Student s2)
            //        {
            //            return s1.Name.CompareTo(s2.Name);
            //        }
            //    );

            //Rut gon 2: ap dung quy tac Labda expression de rut gon ham Anonmyous function
            listStudent.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));
        }

        public void SortByType()
        {
            listStudent.Sort(new TypeComparer());
        }

        public void ReadFromFile(string FileName)
        {
            StreamReader reader = new StreamReader(FileName);
            string line;
            listStudent.Clear();
            while ((line=reader.ReadLine()) != null)
            {
                string[] items = line.Split('|');
                Student s = null;
                if (items[0].Equals("1"))
                {
                    s = new Student(
                        Convert.ToInt32(items[1]),
                        items[2],
                        Convert.ToDateTime(items[3])
                        );
                }
                else if (items[0].Equals("2"))
                {
                    s = new ForeignStudent(Convert.ToInt32(items[1]),
                        items[2],
                        Convert.ToDateTime(items[3]), items[4]);
                }
                else if (items[0].Equals("3"))
                    s = new VNStudent(Convert.ToInt32(items[4]), Convert.ToInt32(items[1]),
                        items[2],
                        Convert.ToDateTime(items[3]));
                else throw new Exception("Invalid student type");
                listStudent.Add(s);
            }
            reader.Close();
        }

        public void WriteToFile(string FileName)
        {
            StreamWriter writer = new StreamWriter(FileName);
            foreach (Student s in listStudent)
                writer.WriteLine(s.GetContextString());
            writer.Close();
        }
    }
}
