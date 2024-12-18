using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedListNONGENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList contries = new SortedList(); //we don't have to specify the datatype
            contries.Add(1, "India");
            contries.Add(3, "United Kingdom"); // sorting take place on Key only data type of key can't be change
            contries.Add(2, "India");

            if(contries.Count > 0)
            {
                foreach(DictionaryEntry country in contries)
                {
                    Console.WriteLine(country.Key + " " + country.Value);
                }
            }
            Console.ReadLine();
        }
    }
}
