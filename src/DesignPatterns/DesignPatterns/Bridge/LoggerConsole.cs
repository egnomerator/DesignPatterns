using System;

namespace DesignPatterns.Bridge
{
    public class LoggerConsole : Logger
    {
        public LoggerConsole(IFormatter formatter) : base(formatter)
        {
        }

        public override void Log(string title, string message)
        {
            Console.WriteLine("Logging to console ...");
            Console.WriteLine(_formatter.Format(title, message));
        }
    }
}
