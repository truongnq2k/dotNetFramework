using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.IO;

namespace FileInitialization
{
    public class FileText
    {
        private static FileStream fs;
        #region Read File
        public static void ReadData(string FileName)
        {
            //phai co file moi doc duoc
            if (File.Exists(FileName))
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
            else
            {
                Console.WriteLine("File doesn't exist!");
            }
        }
        #endregion
        #region Write File
        public static bool WriteData(string FileName, string data)
        {
            try
            {
                fs = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.None);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(data);
                sw.Flush();
                sw.Close();
                fs.Close();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("Write Data Faild ! \nCode: " + e);
                return false;
            }
        }
        #endregion

    }
}
