using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player otherPlayer)
        {
            int otherRoll = otherPlayer.Roll();
            int myRoll = otherRoll + 1;
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{otherPlayer.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{otherPlayer.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }

    }
}