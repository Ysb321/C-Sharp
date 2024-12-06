using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierachicalExample
{
    public class Vehical
    {
        public Vehical()
        {
            Console.WriteLine("This is Vehical");
        }
        public string VehicalCompany { get; set; }
        public string VehicalType { get; set; }
    }

    public class Car : Vehical
    {
        public Car()
        {
            Console.WriteLine("This is Car");
        }
        public  string CarCompany { get; set; }
        public string CarType { get; set; }
        public DateTime CarMFD { get; set; }
    }

    public class Bus : Vehical
    {
        public Bus()
        {
            Console.WriteLine("This is Bus");
        }
        public int BusId { get; set; }
        public DateTime BusMFD { get; set; }
        public string BusStatus { get; set; }
    }


}
