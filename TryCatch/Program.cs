using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number:");
            string input = Console.ReadLine();

            try
            {
                int inputNum = int.Parse(input);
                Console.WriteLine($"Your guess was {inputNum}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Not a valid number");
            }
        }
    }
}
