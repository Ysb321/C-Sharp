using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public static class GuessingNumber
    {
        public static void MinMax(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max + 1);
            int guess = 0;
            int count = 0;
            bool isPlaying = true;
            string response;

            while (isPlaying)
            {
                Console.WriteLine($"Guess a Number between {min} to {max}");
                Console.Write("-> ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Guessed number is {guess}");
                count++;

                if (guess > number)
                {
                    Console.WriteLine("The Guess Number is Too high than actual number");
                    Console.WriteLine();

                }
                else if (guess < number)
                {
                    Console.WriteLine("The Guess Number is Too Low than actual number");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Congratualtion!! Right Guess");
                    Console.WriteLine($"Number of Guesses are {count}");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Play it again (Y/N)?");
                    Console.Write("-> ");
                    response = Console.ReadLine();
                    Console.WriteLine();
                    response = response.ToUpper();
                    if (response != "Y")
                    {
                        isPlaying = false;
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You are Playing Again!!");
                        Console.WriteLine();
                    }
                }

            }

        }
    }
}
