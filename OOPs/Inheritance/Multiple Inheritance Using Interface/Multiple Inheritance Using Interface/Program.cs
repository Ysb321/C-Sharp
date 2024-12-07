using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance_Using_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeroHonda obj  = new HeroHonda();
            Console.WriteLine("Parts Details " + obj.PartDetails());
            Console.WriteLine("Manufacture Date of Parts " + obj.ManufactureDate());
            Console.WriteLine("Engine Details " + obj.EnginDetails());
            Console.WriteLine("Manufacture Date of Engine " + obj.ManufactureDate());
            Console.ReadLine();
        }
    }
}
