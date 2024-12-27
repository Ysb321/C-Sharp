using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    public class Subscriber
    {
        public void RecevieMessage(string message)
        {
            Console.WriteLine("Event Message " + message);
        }
    }
}
