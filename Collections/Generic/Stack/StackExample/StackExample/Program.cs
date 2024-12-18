using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); //First in Last Out
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();

            if (stack.Count > 0)
            {
                foreach (int item in stack)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
