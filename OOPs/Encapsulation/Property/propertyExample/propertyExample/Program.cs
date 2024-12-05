using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetFunction();
            Console.ReadLine();
        }

        public static void GetFunction()
        {
            EmployeeDatal empObj = new EmployeeDatal();
            empObj.EmpName = "Yashraj";
            empObj.EmpJoin = DateTime.Now;
            empObj.EmpId = 1;

            Console.WriteLine("Name of Employee is " + empObj.EmpName);
            Console.WriteLine("Joining Date of Employee is " + empObj.EmpJoin);
            Console.WriteLine("Id of Employee is " + empObj.EmpId);
            
        }
    }
}
