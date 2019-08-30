using System;

namespace DesignPatterns.Bridge
{
    public abstract class Logger
    {
        protected readonly IFormatter _formatter;

        public Logger(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public abstract void Log(string title, string message);
    }
}
