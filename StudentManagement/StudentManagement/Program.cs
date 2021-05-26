using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace StudentManagement
{
    class Program
    {
        #region List Student
        static List<Student> Students = new List<Student>();
        static Student s = new Student();
        static Student s1 = new ForeignStudent();
        static Student s2 = new VietNamStudent();
        #endregion

        #region Void Main
        static FileText ft = new FileText();
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        InputFunction();
                        break;
                    case 2:
                        DisplayStudent();
                        break;
                    case 3:
                        Console.Write("Input id to find: ");
                        int idf = Convert.ToInt32(Console.ReadLine());
                        if (FindById(idf))
                        {
                            Console.WriteLine("Found!");
                        }
                        else
                        {
                            Console.WriteLine("Not Found!");
                        }
                        break;
                    case 4:
                        SortFunction();
                        break;
                    case 5:
                        return;
                }
            }
        }
        #endregion

        #region Main menu
        static void Menu()
        {
            Console.WriteLine("############################");
            Console.WriteLine("1: Input Student");
            Console.WriteLine("2: Display Student");
            Console.WriteLine("3: Find Student By ID");
            Console.WriteLine("4: Sort");
            Console.WriteLine("5: Exit Program");
            Console.WriteLine("############################\n");
        }
        #endregion

        #region Input Student

        static void MenuInputStudent()
        {
            Console.WriteLine("\t---------------------");
            Console.WriteLine("\t1: Simple Student");
            Console.WriteLine("\t2: Foreign Student");
            Console.WriteLine("\t3: VietNam Student");
            Console.WriteLine("\t4: Init Student");
            Console.WriteLine("\t5: Back Main Menu _|");
            Console.WriteLine("\t---------------------");
        }

        static void InputFunction()
        {
            ft.FileName = @"E:\Leaning\semester-5\Prn_Code_In_Class\StudentManagement\student.txt";
            while (true)
            {
                MenuInputStudent();
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Students.Add(AddStudent(s));
                        ft.WriteData("1" + s.ToString());
                        Console.ReadLine();
                        Console.WriteLine("Add successfully!");
                        break;
                    case 2:
                        Students.Add(AddStudent(s1));
                        ft.WriteData("2" + s.ToString());
                        Console.ReadLine();
                        Console.WriteLine("Add successfully!");
                        break;
                    case 3:
                        Students.Add(AddStudent(s2));
                        ft.WriteData("3" + s.ToString());
                        Console.ReadLine();
                        Console.WriteLine("Add successfully!");
                        break;
                    case 4:
                        InitStudent();
                        ft.UpdateListData(Students);
                        Console.WriteLine("Init successfully!");
                        break;
                    case 5:
                        return;
                }
            }
        }

        static Student AddStudent(Student s)
        {
            s.Input();
            return s;
        }

        static void InitStudent()
        {
            Students.Add(new Student(1, "Nguyen Quang Truong", DateTime.Parse("15 Jun 2000")));
            Students.Add(new Student(13, "Nguyen Van Long", DateTime.Parse("23 Sep 2004")));
            Students.Add(new Student(7, "La Thanh Hai", DateTime.Parse("06 May 1995")));
            Students.Add(new Student(10, "Duong Tien Dung", DateTime.Parse("27 Aug 2002")));
            Students.Add(new Student(4, "Vu Lam Oanh", DateTime.Parse("11 Nov 2001")));

            Students.Add(new ForeignStudent(2, "Tran Van Kha", DateTime.Parse("12 Feb 2005"), "Viet Nam"));
            Students.Add(new ForeignStudent(14, "Phan Hoang Nam", DateTime.Parse("13 Sep 1991"), "Campuchia"));
            Students.Add(new ForeignStudent(8, "Trinh Thi Mai Huong", DateTime.Parse("06 May 1995"), "Thai Lan"));
            Students.Add(new ForeignStudent(11, "Pham Thi Huyen", DateTime.Parse("17 Jan 2002"), "Laos"));
            Students.Add(new ForeignStudent(5, "Nguyen Manh Tung", DateTime.Parse("11 Jul 2003"), "Tau khua"));

            Students.Add(new VietNamStudent(3, "Vo Anh Duc", DateTime.Parse("15 Jun 2000"), "324121"));
            Students.Add(new VietNamStudent(15, "Luu Ngoc Long", DateTime.Parse("23 Dec 2001"), "423152"));
            Students.Add(new VietNamStudent(9, "Nguyen Quang Duy", DateTime.Parse("06 May 1995"), "654243"));
            Students.Add(new VietNamStudent(12, "Trang Cong Phu", DateTime.Parse("28 Aug 2002"), "124323"));
            Students.Add(new VietNamStudent(6, "Le Nhu Bac", DateTime.Parse("05 Oct 2001"), "954332"));
        }

        #endregion

        #region Display Student
        static void DisplayStudent()
        {
            //foreach(Student stu in Students)
            //{
            //    Console.WriteLine(stu);
            //}

            ft.ReadData();
        }
        #endregion

        #region Find By ID
        static bool FindById(int id)
        {
            foreach(Student stu in Students)
            {
                if (id == stu.Id)
                {
                    Console.WriteLine(stu);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Sort Student
        static void MenuSortStudent()
        {
            Console.WriteLine("\t---------------------");
            Console.WriteLine("\t1: Sort By Name");
            Console.WriteLine("\t2: Sort By ID");
            Console.WriteLine("\t3: Sort By Date Of Birth");
            //if same type, sort by id
            Console.WriteLine("\t4: Sort By Type");
            Console.WriteLine("\t5: Back Main Menu _|");
            Console.WriteLine("\t---------------------");
        }

        static void SortFunction()
        {
            while (true)
            {
                MenuSortStudent();
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Students.Sort((a, b) => a.Name.CompareTo(b.Name));
                        ft.UpdateListData(Students);
                        DisplayStudent();
                        break;
                    case 2:
                        Students.Sort((a, b) => a.Id.CompareTo(b.Id));
                        ft.UpdateListData(Students);
                        DisplayStudent();
                        break;
                    case 3:
                        Students.Sort((a, b) => a.Dob.CompareTo(b.Dob));
                        ft.UpdateListData(Students);
                        DisplayStudent();
                        break;
                    case 4:
                        //TypeComparer tc = new TypeComparer();
                        Students.Sort(new TypeComparer());
                        ft.UpdateListData(Students);
                        DisplayStudent();
                        break;
                    case 5: return;

                }
            }
        }
        #endregion
    }
}
