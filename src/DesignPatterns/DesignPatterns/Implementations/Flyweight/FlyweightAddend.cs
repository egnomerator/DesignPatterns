namespace DesignPatterns.Implementations.Flyweight
{
    public class FlyweightAddend : IFlyweightAddend
    {
        public static int InstanceCount;

        private readonly int _addendValue;

        public FlyweightAddend(int addendValue)
        {
            InstanceCount++;
            _addendValue = addendValue;
        }

        public int Add(int addend)
        {
            return _addendValue + addend;
        }
    }
}
