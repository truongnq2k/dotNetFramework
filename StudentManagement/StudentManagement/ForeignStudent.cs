using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class ForeignStudent : Student
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
            Console.WriteLine("Enter country: ");
            country = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + "| " +  country;
        }
    }
}
