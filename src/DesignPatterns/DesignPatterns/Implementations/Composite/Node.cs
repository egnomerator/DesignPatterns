using System;
using System.Collections.Generic;

namespace DesignPatterns.Implementations.Composite
{
    public class Node : INode
    {
        private readonly int _depth;
        private readonly string _name;
        private readonly List<INode> _nodes;

        public Node(int depth, string name, List<INode> nodes = null)
        {
            _depth = depth;
            _name = name;
            _nodes = nodes ?? new List<INode>();
        }

        public void PrintMe()
        {
            Console.WriteLine(Utility.GetNodeName(_depth, _name));
            _nodes.ForEach(n => n.PrintMe());
        }
    }
}
