using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer devObj = new Developer();
            devObj.PersonName("Yashraj");
            Console.WriteLine("Employee Id: " + devObj.EmployeeId());
            Console.WriteLine("Technology Working On: " + devObj.Technolgy());
            Console.ReadLine();
        }
    }
}
 