using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Debug("Start GetEmployee Name ");
            Console.WriteLine("Employee Name " + Employe.GetMassage()); // calling static function without object
            Log.Debug("End GetEmployee Name ");

            Log.Debug("Start GetEmployee Salary ");
            Console.WriteLine("Employee Salary " + Employe.PayrollDetails());
            Log.Debug("End GetEmployee Salary ");

            Manager ManagerObj = new Manager();
            ManagerObj.ManagerName();

            Console.ReadLine();
        }
    }
}
