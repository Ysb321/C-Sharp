using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue(); // First Element will be deleted

            Console.WriteLine("Total Numbers of Queue Elements are " + queue.Count);
            if(queue.Count>0)
            {
                foreach(int item in queue)
                {
                    Console.WriteLine("Queue element : " + item);
                }
            }
            Console.ReadLine();
        }
    }
}
