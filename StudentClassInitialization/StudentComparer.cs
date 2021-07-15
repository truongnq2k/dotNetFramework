using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentClassInitialization
{

    public class IdComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.Id.CompareTo(s2.Id);
        }
    }

    public class DobComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.Dob.CompareTo(s2.Dob);
        }
    }

    public class NameComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }
    }

    public class TypeComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.GetType().Name.CompareTo(s2.GetType().Name) == 0)
                return s1.Id.CompareTo(s2.Id);
            else return s1.GetType().Name.CompareTo(s2.GetType().Name);
        }
    }
}
