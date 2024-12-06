using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singel_Inheritance
{
    public class Employee:Audit
    {
        public Employee()
        {
            Console.WriteLine("This is Derived Class Constructor. ");
        }

        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public int EmpSalary { get; set; }
    }
}
