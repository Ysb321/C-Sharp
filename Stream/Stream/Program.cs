using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";

            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine("Hello");
            }

            using (StreamReader sr = new StreamReader(filepath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
