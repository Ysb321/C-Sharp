using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
   public delegate void MyEventHandler(string message); // we have create delegate in Publisher only
    public class Publisher
    {
        public event MyEventHandler MessageSenderClick; // Creating an event

        public void Message(string message)
        {
            Console.WriteLine("Event Message " + message);
        }

        public void RaseEvent(string message)
        {
            
                MessageSenderClick?.Invoke(message); // Invoking method

            
        }
    }
}
