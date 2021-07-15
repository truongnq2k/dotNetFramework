using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentClassInitialization
{
    public class Student
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
            Console.WriteLine("Input student id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input student name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter student date: ");
            dob = Convert.ToDateTime(Console.ReadLine());
        }

        public override string ToString()
        {
            return String.Format("{0} | {1} | {2}", id, name, dob);
        }
    }

    public class ForeignStudent : Student
    {
        private string country;

        public ForeignStudent()
        {
        }
        public ForeignStudent(int id, string name, DateTime dob, string country) : base(id, name, dob)
        {
            this.country = country;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter student country: ");
            country = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + " | " + country;
        }
    }

    public class VietNamStudent : Student
    {
        private int identityNumber;


        public VietNamStudent()
        {

        }
        public VietNamStudent(int id, string name, DateTime dob, int identityNumber) : base(id, name, dob)
        {
            this.identityNumber = identityNumber;
        }

        public int IdentityNumber
        {
            get { return identityNumber; }
            set { identityNumber = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter student identity: ");
            identityNumber = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + " | " + identityNumber;
        }
    }
}
