using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalNum;
            Console.WriteLine("Enter a number: ");
            finalNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Printing Number upto " + finalNum);
            for(int  i = 1; i<=finalNum; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Skipping number 5");
            for(int i = 1; i<=finalNum; i++)
            {
                if(i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("Stoping Loop at 5");
            for(int i=1; i<=finalNum; i++)
            {
                Console.WriteLine(i);
                if(i==5)
                {
                    break;
                }
                
            }
        }
    }
}
