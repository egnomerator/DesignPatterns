using System;

namespace DesignPatterns.Implementations.Factory
{
    public class Knight : IFighter
    {
        public void Attack()
        {
            Console.WriteLine("Sword swung!");
        }
    }
}
