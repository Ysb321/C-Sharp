using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List Example");
            ArrayList contries = new ArrayList () { "India", 123, "USA"};
            contries.Add("IND");
            contries.Add("UK");
            contries.Add("US");
            if (contries.Count > 0)
            {
                foreach (var country in contries)
                {
                    Console.WriteLine(country);
                }
            }
            Console.ReadLine();
        }
    }
}
