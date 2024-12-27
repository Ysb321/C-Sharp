using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeekDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter day: ");
            //int day = Convert.ToInt32(Console.ReadLine());
            WeekDays today = WeekDays.Friday;

            switch (today)
            {
                case WeekDays.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;

                case WeekDays.Monday:
                    Console.WriteLine("Today is Monday");
                    break;

                case WeekDays.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;

                case WeekDays.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine("Today is Thusday");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;
            }

            Console.ReadLine();
        }
    }
}
