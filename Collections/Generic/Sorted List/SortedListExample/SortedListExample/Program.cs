using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> names = new SortedList<int, string>(); // It will sorted data from accending order
            names.Add(1, "Yashraj");
            names.Add(3, "Yashraj");
            names.Add(2, "Yashraj");

            if(names.Count > 0)
            {
                foreach (var item in names)
                {
                    Console.WriteLine("Key : " + item.Key + " Values : " + item.Value);
                }  
            }
            Console.ReadLine();
        }
    }
}
