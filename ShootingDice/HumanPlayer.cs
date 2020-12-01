using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            while (true)
            {
                Console.WriteLine("What do you want to roll?");
                string userDefinedRoll = Console.ReadLine();
                try
                {
                    int rollVallue = int.Parse(userDefinedRoll);
                    return rollVallue;
                }

                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}