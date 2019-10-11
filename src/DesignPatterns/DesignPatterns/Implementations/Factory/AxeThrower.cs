using System;

namespace DesignPatterns.Implementations.Factory
{
    public class AxeThrower : IFighter
    {
        public void Attack()
        {
            Console.WriteLine("Axe thrown!");
        }
    }
}
