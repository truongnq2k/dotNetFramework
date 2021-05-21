using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class SortByName : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }

    class SortById: IComparer
    {
        public int Compare(object x, object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;
            if (s1 == null || s2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (s1.Id > s2.Id)
                {
                    return 1;
                }
                else if (s1.Id == s2.Id)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }

    class SortByDob
    {
    }
}
