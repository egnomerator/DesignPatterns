using System;

namespace DesignPatterns.Implementations.Flyweight
{
    public class Addend
    {
        public static int InstanceCount;

        private readonly Random _random;
        public int AddendValue;

        public Addend(Random random)
        {
            InstanceCount++;
            _random = random;
        }

        public void SetValue()
        {
            AddendValue = _random.Next(1, 3);
        }

        public int Add(int addend)
        {
            return addend + AddendValue;
        }
    }
}
