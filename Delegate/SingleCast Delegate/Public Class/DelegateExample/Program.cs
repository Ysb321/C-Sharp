using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Program
    {
        delegate void ContentDisplay(); // This is a default delegate there is no arguments orparameter and should be same return type of all functions
        static void Main(string[] args)
        {
            Content obj = new Content();
            //obj.display();
            //obj.show();
            //obj.print();
            ContentDisplay delObj = obj.display;
            delObj();
            Console.ReadLine();
        }
    }
}
