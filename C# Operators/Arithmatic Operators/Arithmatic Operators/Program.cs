using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 12;
            int secondNumber = 13;

            int Addition = firstNumber + secondNumber; // + Operator
            int Substraction = firstNumber - secondNumber; // - Operator
            int Multiplication = firstNumber * secondNumber; // * Operator
            int Division = firstNumber / secondNumber; // / Operator
            int Modulus = firstNumber % secondNumber; // % Operator

            Console.WriteLine(Addition);
            Console.WriteLine(Substraction);
            Console.WriteLine(Multiplication);
            Console.WriteLine(Division);
            Console.WriteLine(Modulus);
            Console.ReadLine();
        }
    }
}
