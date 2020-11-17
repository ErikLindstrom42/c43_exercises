using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int secretNumber = r.Next(1, 101);
            int numAttempts = 7;

            while (numAttempts >= 0)
            {
                Console.WriteLine("Guess a number");
                string userResponse = Console.ReadLine();
                int guess = int.Parse(userResponse);
                if (guess == secretNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (guess > secretNumber)
                {
                    numAttempts--;
                    Console.WriteLine($"Too high, you have {numAttempts} remaining");

                }
                else
                {
                    numAttempts--;
                    Console.WriteLine($"Too low, you have {numAttempts} remaining");

                }

            }

        }
    }
}

