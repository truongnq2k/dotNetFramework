using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentManagementFinal
{
    class Validation
    {
        #region Check Input String Number
        public int checkRangNumber(int num1, int num2, string number)
        {
            try
            {
                int num = Convert.ToInt32(number);
                if (num >= num1 && num <= num2)
                {
                    return num;
                }
                else
                    throw new Exception();
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        #region Check isValidNameFormat - Bool
        //check name format
        public bool isValidNameFormat(string TestString)
        {
            string reg = "^[a-zA-Z_ ]*$";
            Regex regex = new Regex(reg);
            if (regex.IsMatch(TestString))
                return true;
            else
                return false;
        }
        #endregion

        #region Check isValidNameFormat - Bool
        //check number format
        public bool isValidNumberFormat(string TestString)
        {
            string reg = "^[0-9]*$";
            Regex regex = new Regex(reg);
            if (regex.IsMatch(TestString))
                return true;
            else
                return false;
        }
        #endregion
    }
}
