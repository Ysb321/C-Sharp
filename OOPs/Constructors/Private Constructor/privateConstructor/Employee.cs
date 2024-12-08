using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateConstructor
{
    public class Employee
    {
        private Employee() // we cant access outside of class
        {
            Console.WriteLine("This is Default Constructor");
        }
        public void GetMassage()
        {
            Console.WriteLine("Hello");
        }
       
    }
}
