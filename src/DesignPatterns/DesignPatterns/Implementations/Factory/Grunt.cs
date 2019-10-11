using System;

namespace DesignPatterns.Implementations.Factory
{
    public class Grunt : IFighter
    {
        public void Attack()
        {
            Console.WriteLine("Axe Swung!");
        }
    }
}
