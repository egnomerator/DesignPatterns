namespace DesignPatterns.Implementations.Composite
{
    public interface INode
    {
        void PrintMe();
    }

    public static class Utility
    {
        public static string GetNodeName(int depth, string name)
        {
            return $"{new string('-', depth)}{name}";
        }
    }
}
