using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            string userResponse = Console.ReadLine();
            int guess = int.Parse(userResponse);
            Console.WriteLine(guess);
        }
    }
}
