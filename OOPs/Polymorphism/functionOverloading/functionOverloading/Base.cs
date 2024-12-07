using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionOverloading
{
    public class Base
    {
        public void Name() // Fuction Name should be same and parameter must be different.
        {
            Console.WriteLine("This is First Function.");
        }
        public void Name(int num)
        {
            Console.WriteLine("This is Second Function." + num);
            //return 2;
        }
    }
}
