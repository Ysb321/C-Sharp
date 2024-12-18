using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstNum, secondNum, result;
                Console.WriteLine("Enter a first Number and second Number");
                firstNum = Convert.ToInt32(Console.ReadLine());
                secondNum = Convert.ToInt32(Console.ReadLine());
                result = firstNum / secondNum;
                Console.WriteLine("Result : " + result);
            }
            catch (Exception ex) // catching the errors, if their is error in try block then it comes in catch part
            {
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
            }
            finally // this block will always will executed, for cleanup the block
            {
                Console.WriteLine("This Final block will execute");
            }
            Console.ReadLine();
        }
    }
}
