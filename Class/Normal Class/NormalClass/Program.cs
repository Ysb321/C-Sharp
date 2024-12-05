using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data dataObj = new Data();
            dataObj.GetMassage();
            Console.WriteLine("Number of Data: " + dataObj.GetNumber());
            Console.ReadLine();
        }
    }
}
