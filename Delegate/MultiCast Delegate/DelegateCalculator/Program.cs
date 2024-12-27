using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    internal class Program
    {
        delegate int CalcutionDel(int num1, int num2); // This is Multicast delegate where we have to pass parameter and return type should be same
        static void Main(string[] args)
        {
            CalcutionDel delAdd = Calculation.Addition; // creating an object of delegate
            CalcutionDel delSub = Calculation.Substraction;
            CalcutionDel delMulti = Calculation.Multiplication;
            CalcutionDel delDiv = Calculation.Division;

            Console.WriteLine("Addition : " + delAdd(12, 22)); // Passing values to functions
            Console.WriteLine("Substraction : " + delSub(12, 22));
            Console.WriteLine("Multiplication : " + delMulti(12, 22));
            Console.WriteLine("Division : " + delDiv(12, 22));

            Console.ReadLine();
        }
    }
}
