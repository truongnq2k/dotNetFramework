using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class VietNamStudent : Student
    {
        private string identityNumber;


        public VietNamStudent()
        {

        }
        public VietNamStudent(int id, string name, DateTime dob, string identityNumber) : base(id, name, dob)
        {
            this.identityNumber = identityNumber;
        }

        public string IdentityNumber
        {
            get { return identityNumber; }
            set { identityNumber = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter identity: ");
            identityNumber = Console.ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + identityNumber;
        }
    }
}
