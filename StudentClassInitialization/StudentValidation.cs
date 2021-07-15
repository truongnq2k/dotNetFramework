using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace StudentClassInitialization
{
    public class StudentValidation
    {
        #region Check isValidNameFormat - Bool
        //check name format
        public static bool isValidNameFormat(string TestString)
        {
            string reg = "^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
            Regex regex = new Regex(reg);
            if (regex.IsMatch(TestString))         
                return true;
            else
                return false;
        }
        #endregion
        #region Check isExistedStudentId - Bool
        public static bool isExistedStudentId(int id, List<Student> students)
        {
            foreach(Student stu in students)
            {
                if (stu.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
