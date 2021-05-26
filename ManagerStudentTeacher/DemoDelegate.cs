using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    delegate int Calculation(int a, int b);//dinh nghia 1 kieu delegate
    class DemoDelegate
    {
        public static int Add(int x, int y)
        {
            Console.WriteLine("Add function.");
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            Console.WriteLine("Sub function.");
            return x - y;
        }

        public static int Mul(int x, int y)
        {
            Console.WriteLine("Mul function.");
            return x * y;
        }
        public static void DemoBasicDelegate()
        {
            Calculation c = new Calculation(Add);// Calculation c = Add
            Console.WriteLine(c(5, 4));//Loi goi toi ham Add(5,4)

            c = Sub;
            Console.WriteLine(c(5, 4));

            Console.WriteLine("\nDemo multicast:");
            c += Add;
            c += Mul;
            c += Add;
            c -= Add;
            Console.WriteLine(c(5, 4));
        }
    }
}
