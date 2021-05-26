using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    class Validate
    {
        #region
        /**
        * Duy nhat 1 ID
        * Phai la student
        * 
        */

        /**
         * Return true if existed id in lis
         */
        public bool isExistedId(int id, List<Student> students)
        {
            foreach(Student st in students)
            {
                //da co id trong list
                if (st.Id == id)
                {
                    return true;
                }
            }
            //tra ve fales khi khong bi trung id
            return false;
        }


        //return Type of student if valid
        public Type isStudent(String line)
        {
            try
            {

            }
            catch
            {

            }
            return null;
        }


        #endregion
    }
}
