using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment obj = new Assignment();

            int a = obj.firstNumber();
            int b = obj.secondNumber();

            Console.WriteLine(a += b); // +=
            Console.WriteLine(a -= b); // -=
            Console.WriteLine(a *= b); // *=
            Console.WriteLine(a /= b); // /=
            Console.WriteLine(a %= b); // %=
            Console.ReadLine();
        }
    }
}
