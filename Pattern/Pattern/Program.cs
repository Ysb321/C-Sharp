using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
