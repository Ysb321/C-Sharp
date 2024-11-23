using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = " Hello World ";
            Console.WriteLine("String is : " + name);
            Console.WriteLine("Length of String is : " + name.Length);
            Console.WriteLine("UpperCase of String is : " + name.ToUpper());
            Console.WriteLine("LowerCase of String is : " + name.ToLower());
            Console.WriteLine("Trim of String is : " + name.Trim());
            Console.ReadLine();
        }
    }
}
