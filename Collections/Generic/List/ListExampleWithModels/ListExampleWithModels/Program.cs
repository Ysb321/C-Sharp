using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExampleWithModels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> list = new List<Employee>();

            //Employee obj = new Employee();
            //obj.Name = "Yash";
            //obj.Salary = 10;
            //obj.Email = "email@gmail.com";

            //Employee obj2 = new Employee();
            //obj2.Name = "Yashraj";
            //obj2.Salary = 10000;
            //obj2.Email = "email2@gmail.com";

            //list.Add(obj);
            //list.Add(obj2);

            //Easy Way

            List<Employee> employeeList = new List<Employee>
            {
                new Employee { Name = "Yashraj", Salary = 123, Email = "test@gmail.com" }, // don't create a object direct putting values to datamembers
                new Employee { Name = "Yashraj2", Salary = 332, Email = "new@gmail.com" }
            };


            if (employeeList.Count > 0)
            {
                foreach (var emp in employeeList)
                {
                    Console.WriteLine(emp.Name);
                    Console.WriteLine(emp.Salary);
                    Console.WriteLine(emp.Email);
                }
            }
            Console.WriteLine(employeeList.Count);
            Console.ReadLine();

        }
    }
}
