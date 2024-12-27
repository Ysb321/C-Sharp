using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    public static class Calculation
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
