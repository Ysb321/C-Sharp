using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            //MyEventHandler delObj = publisher.Message;
            MyEventHandler delObj = publisher.RaseEvent;
            delObj += subscriber.RecevieMessage;
            delObj("Hello");
            Console.ReadLine();
        }
    }
}
