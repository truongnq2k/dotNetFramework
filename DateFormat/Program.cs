using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Now;
            Console.WriteLine("Date String in Current Culture: " + dt.ToString("d"));
            Console.WriteLine("MM/dd/yyyy Format: " + dt.ToString("MM/dd/yyyy"));
            Console.WriteLine("dd/MM/yyyy Format: " + dt.ToString("dd/MM/yyyy"));
            Console.WriteLine("MM/dd/yy Format: " + dt.ToString("MM/dd/yy"));
            Console.WriteLine("dddd, dd MMMM yyyy Format: " + dt.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine("MM/dd/yyyy h:mm tt Format: " + dt.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine("MMMM dd Format: " + dt.ToString("MMMM dd"));
            Console.WriteLine("HH:mm:ss Format: " + dt.ToString("HH:mm:ss"));
            Console.WriteLine("hh:mm tt Format: " + dt.ToString("hh:mm tt"));
            Console.WriteLine("Short Date String: " + dt.ToShortDateString());
            Console.WriteLine("Long Date String: " + dt.ToLongDateString());
            Console.WriteLine("Short Time String: " + dt.ToShortTimeString());
            Console.WriteLine("Long Time String: " + dt.ToLongTimeString());
        }
    }
}
