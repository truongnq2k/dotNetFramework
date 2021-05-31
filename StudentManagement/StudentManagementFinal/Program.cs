using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using StudentClassInitialization;
using FileInitialization;

namespace StudentManagementFinal
{
    #region Declare Delegate
    delegate void HandleNumberList(int OldNumber, int NewNumber);
    delegate void HandleInforChange();
    #endregion

    class Program
    {
        #region Event List Change
        public static void OnNumberOfStudentChanged(int Before, int After)
        {
            Console.WriteLine($"List student changed from {Before} to {After} !");

        }
        #endregion

        #region List Student
        static List<Student> Students = new List<Student>();
        static Student s = new Student();
        static Student s1 = new ForeignStudent();
        static Student s2 = new VietNamStudent();      
        #endregion

        #region Method Main
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
                        if (FindById(idf, Students))
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
            Console.WriteLine("\t5: Get Student From File");
            Console.WriteLine("\t6: Back Main Menu _|");
            Console.WriteLine("\t---------------------");
        }

        static void InputFunction()
        {
            while (true)
            {
                MenuInputStudent();
                TotalStudent ts = new TotalStudent(Students.Count);
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        ts.NumStudentChanged += OnNumberOfStudentChanged;
                        Students.Add(inputStudent(s));
                        ts.TotalStudents = Students.Count;
                        FileText.WriteData(ConfigurationManager.AppSettings["FileName"].ToString(), "1 | " + s.ToString());
                        Console.WriteLine("Add student successfully!");
                        break;
                    case 2:
                        ts.NumStudentChanged += OnNumberOfStudentChanged;
                        Students.Add(inputStudent(s1));
                        ts.TotalStudents = Students.Count;
                        FileText.WriteData(ConfigurationManager.AppSettings["FileName"].ToString(), "2 | " + s1.ToString());
                        Console.WriteLine("Add Foreign student successfully!");
                        break;
                    case 3:
                        ts.NumStudentChanged += OnNumberOfStudentChanged;
                        Students.Add(inputStudent(s2));
                        ts.TotalStudents = Students.Count;
                        FileText.WriteData(ConfigurationManager.AppSettings["FileName"].ToString(), "3 | " + s2.ToString());
                        Console.WriteLine("Add VN sutdent successfully!");
                        break;
                    case 4:
                        ts.NumStudentChanged += OnNumberOfStudentChanged;
                        InitStudent();
                        ts.TotalStudents = Students.Count;
                        //ft.UpdateListData(Students);
                        Console.WriteLine("Init successfully!");
                        break;
                    case 5:
                        ts.NumStudentChanged += OnNumberOfStudentChanged;
                        Students = convertFileToListStudents(ConfigurationManager.AppSettings["FileName"].ToString());
                        ts.TotalStudents = Students.Count;
                        Console.WriteLine();
                        break;
                    case 6:
                        return;
                }
            }
        }

        static Student inputStudent(Student s)
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

            Students.Add(new VietNamStudent(3, "Vo Anh Duc", DateTime.Parse("15 Jun 2000"), 324121));
            Students.Add(new VietNamStudent(15, "Luu Ngoc Long", DateTime.Parse("23 Dec 2001"), 423152));
            Students.Add(new VietNamStudent(9, "Nguyen Quang Duy", DateTime.Parse("06 May 1995"), 654243));
            Students.Add(new VietNamStudent(12, "Trang Cong Phu", DateTime.Parse("28 Aug 2002"), 124323));
            Students.Add(new VietNamStudent(6, "Le Nhu Bac", DateTime.Parse("05 Oct 2001"), 954332));
        }

        #endregion

        #region Display Student
        static void DisplayStudent()
        {
            //string FileName = ConfigurationManager.AppSettings["FileName"].ToString();
            //FileText.ReadData(FileName);
            foreach (Student stu in Students)
            {
                Console.WriteLine(stu);
            }
        }
        #endregion

        static void EditStudent(Student s)
        {

        }

        #region Convert LineFile To Student
        public static List<Student> convertFileToListStudents(string FileName)
        {
            List<Student> students = new List<Student>();

            StreamReader sr = new StreamReader(FileName);
            string line;
            Validation validation = new Validation();
            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split('|');

                //Dinh dang
                //1 | 111 | Truong Dep Trai | 11/11/2001 12:00:00 AM | xxxxxx
                // sai dinh dang thi bo qua
                if (items.Length < 4 || items.Length > 5)
                {
                    continue;
                }
                //check xem co phai la 1-2-3 (Stu, Foreign, VN) hay khong
                if (validation.checkRangNumber(1, 3, items[0].Trim()) == -1)
                {
                    continue;
                }
                //check id phai la so hay khong, neu khong phai so thi bo qua
                if (validation.checkRangNumber(0, Int32.MaxValue, items[1].Trim()) == -1)
                {
                    continue;
                }

                //check format name
                if (!StudentValidation.isValidNameFormat(items[2].Trim()))
                {
                    continue;
                }

                //check id da ton tai hay chua
                if (FindById(Convert.ToInt32(items[1].Trim()), students))
                {
                    continue;
                }
                Student s = null;
                if (items[0].Trim().Equals("1"))
                    s = new Student(Convert.ToInt32(items[1].Trim()), items[2].Trim(), Convert.ToDateTime(items[3].Trim()));
                else if (items[0].Trim().Equals("2"))
                {
                    //ten quoc gia khong duoc chua ky tu dac biet va so
                    if (!validation.isValidNameFormat(items[4].Trim()))
                    {
                        continue;
                    }

                    s = new ForeignStudent(Convert.ToInt32(items[1].Trim()), items[2].Trim(), Convert.ToDateTime(items[3].Trim()), items[4].Trim());

                }
                else if (items[0].Trim().Equals("3"))
                {
                    //identity only number
                    if (!validation.isValidNumberFormat(items[4].Trim()))
                    {
                        continue;
                    }
                    s = new VietNamStudent(Convert.ToInt32(items[1].Trim()), items[2].Trim(), Convert.ToDateTime(items[3].Trim()), Convert.ToInt32(items[4].Trim()));
                }
                else throw new Exception("Invalid student type");
                students.Add(s);
            }
            sr.Close();
            return students;
        }
        #endregion

        #region Find By ID
        static bool FindById(int id, List<Student> stus)
        {
            foreach (Student stu in stus)
            {
                if (id == stu.Id)
                {
                    //Console.WriteLine(stu);
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
                        DisplayStudent();
                        break;
                    case 2:
                        Students.Sort((a, b) => a.Id.CompareTo(b.Id));
                        DisplayStudent();
                        break;
                    case 3:
                        Students.Sort((a, b) => a.Dob.CompareTo(b.Dob));
                        DisplayStudent();
                        break;
                    case 4:
                        Students.Sort(new TypeComparer());
                        DisplayStudent();
                        break;
                    case 5: return;

                }
            }
        }
        #endregion
    }
}
