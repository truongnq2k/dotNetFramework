using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class ForeignStudent : Student
    {
        string country;
        public string Country { get => country; set => country = value; }

        public ForeignStudent()
        {
        }

        public ForeignStudent(int id, string name, DateTime dob, string country) : base(id, name, dob)
        {
            this.Country = country;
        }

        public override string ToString()
        {
            return "ForeignStudy: " + base.ToString() + " " + country;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("enter country: ");
            Country = Console.ReadLine();
        }

        public override string GetContextString()
        {
            return $"2|{Id}|{Name}|{Dob}|{country}";
        }
    }
}
