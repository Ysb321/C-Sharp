using static_Constructor_Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Constructor_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp.Message();
            Emp.GetMassage(); // don't call constructor again
        }
    }
}

