using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridInhertance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails obj = new EmployeeDetails();
            Console.WriteLine("Name : " + obj.Name());
            Console.WriteLine("Age : " + obj.Age());
            Console.WriteLine("Address : " + obj.Address());
            Console.WriteLine("Salary : " + obj.EmpSalary());
            Console.ReadLine();
        }
        
    }
}
