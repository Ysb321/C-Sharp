using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            data userDataObj = new data(); // from one object we can call all function
            string name = userDataObj.GetEmployee();
            int num = userDataObj.GetSalary();
            Console.WriteLine(name);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
