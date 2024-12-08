using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Constructor_Example
{
    public class Emp
    {
        static Emp()
        {
            Console.WriteLine("This is constructor");
        }

        public static void Message()
        {
            Console.WriteLine("Hello");
        }
        public static void GetMassage()
        {
            Console.WriteLine("Yash");
        }
    }
}
