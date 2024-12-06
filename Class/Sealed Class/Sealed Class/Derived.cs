using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    public class Derived: seeled // This is showing error bcoz of sealed keyword
    {
        public Derived()
        {
            Console.WriteLine("This is Derived Class");
        }
    }
}
