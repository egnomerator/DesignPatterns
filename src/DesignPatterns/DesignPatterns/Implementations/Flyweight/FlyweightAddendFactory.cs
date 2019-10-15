using System.Collections.Generic;

namespace DesignPatterns.Implementations.Flyweight
{
    public class FlyweightAddendFactory
    {
        private readonly Dictionary<int, IFlyweightAddend> _flyweights;

        public FlyweightAddendFactory()
        {
            _flyweights = new Dictionary<int, IFlyweightAddend>();
        }

        public IFlyweightAddend GetAddend(int addendValue)
        {
            if (!_flyweights.ContainsKey(addendValue)) _flyweights.Add(addendValue, new FlyweightAddend(addendValue));

            return _flyweights[addendValue];
        }
    }
}
