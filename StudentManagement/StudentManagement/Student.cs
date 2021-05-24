using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class Student
    {
        private int id;
        private string name;
        private DateTime dob;

        public Student()
        {
        }

        public Student(int id, string name, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public virtual void Input()
        {
            Console.WriteLine("Input id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter date: ");
            dob = Convert.ToDateTime(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format(" | {0} | {1} | {2} ", id, name, dob);
        }
    }
}
