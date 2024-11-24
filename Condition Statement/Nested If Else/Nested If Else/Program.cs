using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Greater Number:");
            Console.WriteLine("Enter a First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("First Number is Greater than Second.");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("First Number is Same as Second.");
            }
            else
            {
                Console.WriteLine("First Number is Smaller than Second Number");
            }
            Console.ReadLine();

        }
    }
}
