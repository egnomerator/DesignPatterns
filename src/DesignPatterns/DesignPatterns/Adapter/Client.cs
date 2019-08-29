namespace DesignPatterns.Adapter
{
    public class Client
    {
        private readonly ILoggerClientRequires _loggerClientRequires;

        public Client(ILoggerClientRequires loggerClientRequires)
        {
            _loggerClientRequires = loggerClientRequires;
        }

        public void Log(string message)
        {
            _loggerClientRequires.Log(message);
        }
    }
}
