using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();  
            Employee obj1 = new Employee(obj);
            Console.ReadLine();
        }
    }
}
