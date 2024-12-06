using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace multilevel
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("This is Base Class. ");
        }
        public void PersonName(string name)
        {
            Console.WriteLine("Person Name: " + name);
        }
        public string PersonAddress {  get; set; }
    }

    public class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("This is Derived Class.");
        }
        public int EmployeeId()
        {
            return 23;
        }
        public int EmpSalary { get; set; }
    }

    public class Developer : Employee
    {
        public Developer()
        {
            Console.WriteLine("This is Derived Class.");
        }
        public string Technolgy()
        {
            return "C-Sharp";
        }
        public string DevProject { get; set; }
    }
}
