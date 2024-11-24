using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Greater Number");
            Console.WriteLine("Enter a First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string result = num1 > num2 ? "First Number is Greater than Second" : "First Number is Smaller than Second";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
