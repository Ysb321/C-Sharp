using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Logical obj = new Logical();

            if (obj.firstString() != obj.secondString() && obj.firstString().Length == 5) // &&
            {
                Console.WriteLine("Condition is True");
            }
            else
            {
                Console.WriteLine("Condition is False");
            }

            if(obj.firstString() != obj.secondString() || obj.firstString() == "Hello") // ||
            {
                Console.WriteLine("Condition is True");
            }
            else
            {
                Console.WriteLine("Condition is False");
            }

            if(!obj.boolFun())  // !
            {
                Console.WriteLine("Boolean is False");
            }
            else
            {
                Console.WriteLine("Boolean is True");
            }
            Console.ReadLine();
        }
    }
}
