using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            Console.WriteLine("Comapny Name: " + obj.CompanyName());
            Console.WriteLine("Comapny Description: " + obj.CompanyDesc());
            Console.ReadLine();
        }
    }
}
