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

        public void WriteData(Student student)
        {
            fs = new System.IO.FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);

            if ()
            {

            }

            sw.WriteLine(student); //ghi vao file
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
    }
}
