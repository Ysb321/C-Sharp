using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        // When we Want store 
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, string> names = new Dictionary<int, string>(); // int is key and string 
                names.Add(1, "yashraj"); // key must be diffrent
                names.Add(3, "yashraj");
                names.Add(2, "yashraj");

                if (names.Count > 0)
                {
                    foreach (var item in names)
                    {
                        Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
                    }
                }
            } catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            Console.ReadLine();
        }
    }
}
