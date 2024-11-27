using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace arraytest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] obj = { 1, 2, 3, 4 };

            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine("Index is " + i);
                Console.WriteLine(obj[i]);

            }

            string[] obj1 = { "hello", "yash" };
            string[] obj2 = new string[2] { "mon", "sun" };  // for creating an object on dynamic memory
            for (int i = 0; i < obj1.Length; i++)
            {
                Console.WriteLine(obj1[i]);
            }

            foreach (var item in obj2)
            {
                Console.WriteLine(item);
            }

            ArrayList arrayList = new ArrayList(); // Array list it is collection of different data types.
            arrayList.Add("INR");
            arrayList.Add("USD");
            arrayList.Add(223);
            foreach (var array in arrayList)
            {
                Console.WriteLine("Values " + array);
            }
            Console.ReadLine();

        }
    }
}
