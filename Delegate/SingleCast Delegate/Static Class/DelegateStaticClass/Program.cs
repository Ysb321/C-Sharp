using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateStaticClass
{
    internal class Program
    {
        delegate void ContentDisplay(); // It is Default delegate where there is no parameters and same return type
        static void Main(string[] args)
        {
            ContentDisplay delObj = Content.display;
            //ContentDisplay delObj = new ContentDisplay(Content.display); //Another way to create obj of Delegate using new key word
            delObj();
            ContentDisplay delObj2 = Content.show;
            delObj2();
            ContentDisplay delObj3 = Content.print;
            delObj3();
            Console.ReadLine();
        }
    }
}
