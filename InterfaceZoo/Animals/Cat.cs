using System;
namespace InterfaceZoo
{
    public class Cat : IWalking
    {
        public void Walk()
        {
            Console.WriteLine("Walk around");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me!");
        }
    }
}