using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace StudentManagement
{
    class FileText
    {
        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }
        private System.IO.FileStream fs;
        public void WriteData(string text)
        {
            fs = new System.IO.FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            fs = new System.IO.FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs);
            String str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void UpdateListData(List<Student> Students)
        {
            fs = new System.IO.FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);

            foreach (Student stu in Students)
            {
                if (stu.GetType().Name.Equals("Student"))
                {
                    sw.WriteLine("1" + stu.ToString());
                }
                if (stu.GetType().Name.Equals("ForeignStudent"))
                {
                    sw.WriteLine("2" + stu.ToString());
                }
                if (stu.GetType().Name.Equals("VietNamStudent"))
                {
                    sw.WriteLine("3" + stu.ToString());
                }
            }

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
