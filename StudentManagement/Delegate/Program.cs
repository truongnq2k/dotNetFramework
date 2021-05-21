using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{

    delegate int Calculation(int a, int b);//dinh nghia kieu delegate
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation(Add);
            Calculation c1 = new Calculation(Sub);

            c += c1;
            Console.WriteLine(c(5,4));
            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
