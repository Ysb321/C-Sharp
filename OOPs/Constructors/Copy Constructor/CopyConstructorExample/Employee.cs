using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorExample   


{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("This is Default Constructor");
        }
         public Employee(Employee obj)
        {
            Console.WriteLine("This is Copy Constructor");
        }
    }
}
