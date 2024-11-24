using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Greater Number:");
            Console.WriteLine("Enter a First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2)
            {
                Console.WriteLine("The First Number is Greater than Second");
            }
            else
            {
                Console.WriteLine("The Second Number is Greater than Second");
            }

            Console.ReadLine();
    

        }
    }
}
