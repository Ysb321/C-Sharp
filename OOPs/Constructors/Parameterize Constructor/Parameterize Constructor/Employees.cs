using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterize_Constructor
{
    public class Employees
    {
        public Employees(int num, string name)
        {
            Console.WriteLine("The NUmber is " + num + " Name is " + name);
        }
    }
}
