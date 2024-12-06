using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singel_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee();
            empObj.CreatedBY = "Yashraj";
            empObj.CreatedON = DateTime.Now;
            empObj.ModifiedBY = "Yash";
            empObj.ModifiedON = DateTime.UtcNow;

            Console.WriteLine("Created By : "+ empObj.CreatedBY);
            Console.WriteLine("Created On : "+ empObj.CreatedON);
            Console.WriteLine("Modified By  : "+ empObj.ModifiedBY);
            Console.WriteLine("Modified On : "+ empObj.ModifiedON);
            Console.ReadLine();
        }
    }
}
