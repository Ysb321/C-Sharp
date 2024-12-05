using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetData();
            Console.ReadLine();
        }

        public static void GetData()
        {
            Employee employee = new Employee();
            employee.EmpName = "Test";
            employee.CreatedBy = "yashraj";
            employee.CreatedOn = DateTime.Now;
            
            employee.ModifiedBy = "Yashraj";
            employee.ModifiedOn = DateTime.UtcNow;

            Console.WriteLine(employee.EmpName);
            Console.WriteLine(employee.CreatedBy);
            Console.WriteLine(employee.CreatedOn);
            Console.WriteLine(employee.ModifiedBy);
            Console.WriteLine(employee.CreatedOn);
        }

    }

    
    }
