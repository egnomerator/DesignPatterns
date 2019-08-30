using System;

namespace DesignPatterns.Bridge
{
    public class LoggerFile : Logger
    {
        public LoggerFile(IFormatter formatter) : base(formatter)
        {
        }

        public override void Log(string title, string message)
        {
            Console.WriteLine("Pretending to save this log to a file ...");
            Console.WriteLine(_formatter.Format(title, message));
        }
    }
}
