using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    public static class Log
    {
        public static void Info(string message)
        {
            Console.WriteLine(message);
        }

        public static void Debug(string messsage)
        {
            Console.WriteLine(messsage);    
        }
    }
}
