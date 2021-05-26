using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class Student: IComparable<Student>
    {
        int id;
        string name;
        DateTime dob;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public Student()
        {
        }

        public Student(int id)
        {
            this.id = id;
        }

        public Student(int id, string name, DateTime dob)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
        }

        public override string ToString()
        {
            return "Student:" + id +" "+name+" "+dob;
        }

        public virtual string GetContextString()
        {
            return $"1|{id}|{name}|{dob}";
        }

        public virtual void Input()
        {
            Console.Write("enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter name: ");
            name = Console.ReadLine();
            Console.Write("enter dob: ");
            dob = Convert.ToDateTime( Console.ReadLine());
        }


        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   id == student.id;
        }

        public int CompareTo(Student o)
        {
            return this.name.CompareTo(o.name);
        }
    }


}
