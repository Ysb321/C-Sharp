using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            Console.WriteLine("Name: "+ obj.Name());
            Console.ReadLine();
        }
    }
}
