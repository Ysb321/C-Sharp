using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExampleNON_GENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack countries = new Stack();
            countries.Push("Hello");
            countries.Push(12);
            countries.Push("Yashraj");

            if(countries.Count>0)
            {
                foreach(var country in countries)
                {
                    Console.WriteLine(country);
                }
            }
            Console.ReadLine();
        }
    }
}
