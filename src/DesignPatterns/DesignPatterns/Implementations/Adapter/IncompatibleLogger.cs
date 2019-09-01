using System;

namespace DesignPatterns.Implementations.Adapter
{
    public class IncompatibleLogger : IIncompatibleLogger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
