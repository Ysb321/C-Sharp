using System;
using System.Collections.Generic; // for Generic Collection
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Yashraj");
            names.Add("Sunil");
            names.Add("Boralkar"); // To Adding data in List
            names.Remove("Boralkar"); // To removing data from List
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            for (int i = 0; i < names.Count; i++) // can use both Count or Length
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
