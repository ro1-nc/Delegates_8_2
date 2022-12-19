using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_8_2
{
    public delegate void Del1();

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Delegate:");
            Del1 d1 = new Del1(Hello);
            d1();
            Console.WriteLine("Second  Delegate:");
            Del1 d2 = new Del1(Welcome);
            d2();
            Console.WriteLine("MultiDelegate:");
            Del1 d3; // = new Del1();
            d3 = d1 + d2;
            d3();

            Console.ReadKey();
        }
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
        public static void Welcome()
        {
            Console.WriteLine("Welcome");
        }
    }
}
