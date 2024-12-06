using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierachicalExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehical carObj = new Car(); // It can be possible with same result
            Bus busObj = new Bus();
            busObj.VehicalCompany = "TATA";
            busObj.BusMFD = DateTime.Now;
            Console.WriteLine("Vehical Company: " + busObj.VehicalCompany);
            Console.WriteLine("Bus Manufacture Date: " + busObj.BusMFD);
            Console.ReadLine();
        }
    }
}
