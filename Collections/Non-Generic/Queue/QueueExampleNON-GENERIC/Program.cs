using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExampleNON_GENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue countries = new Queue();
            countries.Enqueue("America");
            countries.Enqueue(12);
            countries.Enqueue("India");
            //countries.Dequeue();
           if(countries.Contains("America"))
            {
                Console.WriteLine("heelo");
            }

            if (countries.Count > 0)
            {
                foreach (var country in countries)
                {
                    Console.WriteLine(country);
                }
            }
            Console.ReadLine();
        }
    }
}
