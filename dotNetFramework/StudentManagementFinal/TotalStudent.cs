using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagementFinal
{
    class TotalStudent
    {

        #region Event List Change
        public event HandleNumberList NumStudentChanged;
        #endregion

        private int totalStudents;

        public int TotalStudents
        {
            get
            {
                return totalStudents;
            }
            set
            {
                if (!totalStudents.Equals(value))
                {
                    if (NumStudentChanged != null) NumStudentChanged(totalStudents, value);
                    totalStudents = value;
                }
            }
        }

        public TotalStudent()
        {
        }

        public TotalStudent(int totalStudents)
        {
            TotalStudents = totalStudents;
        }
    }
}
