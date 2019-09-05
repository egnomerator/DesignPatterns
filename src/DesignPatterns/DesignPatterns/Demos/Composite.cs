using DesignPatterns.Implementations.Composite;
using System.Collections.Generic;

namespace DesignPatterns.Demos
{
    public class Composite
    {
        public static void Run()
        {
            var sub1 = new Node(1, "sub1");
            var subsubA = new Node(2, "subsubA");
            var subsubB = new Node(2, "subsubB");
            var sub2 = new Node(1, "sub2", new List<INode> { subsubA, subsubB });
            var subsubsub1 = new Node(3, "subsubsub1");
            var subsubsub2 = new Node(3, "subsubsub2");
            var subsubC = new Node(2, "subsubC", new List<INode> { subsubsub1, subsubsub2 });
            var subsubD = new Node(2, "subsubD");
            var sub3 = new Node(1, "sub3", new List<INode> { subsubC, subsubD });
            var sub4 = new Node(1, "sub4");
            var root = new Node(0, "root", new List<INode> { sub1, sub2, sub3, sub4 });

            root.PrintMe();
        }
    }
}
