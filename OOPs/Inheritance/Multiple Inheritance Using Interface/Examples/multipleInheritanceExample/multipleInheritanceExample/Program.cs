using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            Console.WriteLine("Name: " + obj.Name());
            Console.WriteLine("Surname: " + obj.Surname());
            Console.WriteLine("Age: " + obj.age());
            Console.WriteLine("Salary: " + obj.salary());
            Console.ReadLine();
        }
    }
}
