using System;

namespace DesignPatterns.Adapter
{
    public class IncompatibleLogger : IIncompatibleLogger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
