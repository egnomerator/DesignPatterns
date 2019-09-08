using System;

namespace DesignPatterns.Implementations.Composite
{
    public class Leaf : INode
    {
        private readonly int _depth;
        private readonly string _name;

        public Leaf(int depth, string name)
        {
            _depth = depth;
            _name = name;
        }

        public void PrintMe()
        {
            const string leaf = "->";
            Console.WriteLine($"{Utility.GetNodeName(_depth, _name)} {leaf}");
        }
    }
}
