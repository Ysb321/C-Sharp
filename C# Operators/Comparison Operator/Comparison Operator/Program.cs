using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compare obj = new Compare();

            int a = obj.firstNumber();
            int b = obj.secondNumber();

            Console.WriteLine(a == b); // ==
            Console.WriteLine(a != b); // !=
            Console.WriteLine(a < b); // <
            Console.WriteLine(a > b); // >
            Console.WriteLine(a <= b); // <=
            Console.WriteLine(a >= b); // >=
            Console.ReadLine();
        }
    }
}
