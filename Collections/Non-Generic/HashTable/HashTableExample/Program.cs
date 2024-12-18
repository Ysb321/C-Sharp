using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable countries = new Hashtable();
            countries.Add("IND", "India");
            countries.Add("UK", "United Kindom");
            countries.Add("USA", "United State Of America");
            countries.Add(10, "United State Of America");

            if(countries.Count > 0)
            {
                foreach(DictionaryEntry country in countries) // We have to use DictionaryEntry
                {
                    Console.WriteLine(country.Key + " " + country.Value);
                }
            }
            Console.ReadLine();


        }
    }
}
