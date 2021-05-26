using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class VNStudent : Student
    {
        int indetityNumber;

        public VNStudent()
        {
        }

        public VNStudent(int indetityNumber, int id, string name, DateTime dob) : base(id, name, dob)
        {
            this.indetityNumber = indetityNumber;
        }

        public override string ToString()
        {
            return "VNStudy: " + base.ToString() + " " + indetityNumber;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("enter Indetity Number: ");
            indetityNumber = Convert.ToInt32(Console.ReadLine());            
        }

        public override string GetContextString()
        {
            return $"3|{Id}|{Name}|{Dob}|{indetityNumber}";
        }
    }
}
