using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterize_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees obj = new Employees(12, "Hello");
            Console.ReadLine();
        }
    }
}
