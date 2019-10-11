using System;

namespace DesignPatterns.Implementations.Factory
{
    public class Archer : IFighter
    {
        public void Attack()
        {
            Console.WriteLine("Arrow loosed!");
        }
    }
}
