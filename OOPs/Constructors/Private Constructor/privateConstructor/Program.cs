using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(); // we can't create object of class which contain private constructor
            obj.GetMassage();
        }
    }
}
