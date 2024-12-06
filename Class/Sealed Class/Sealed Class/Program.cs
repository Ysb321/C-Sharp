using Sealed_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
// A sealed class is a class that cannot be inherited by other classes. This means that no other class can derive from a sealed class
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            Console.ReadLine();
        }
    }
}
