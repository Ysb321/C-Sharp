using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.Name();
            baseObj.Name(23);
            Console.ReadLine();
        }
    }
}
