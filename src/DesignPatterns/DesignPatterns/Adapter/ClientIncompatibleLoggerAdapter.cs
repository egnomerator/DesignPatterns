namespace DesignPatterns.Adapter
{
    public class ClientIncompatibleLoggerAdapter : ILoggerClientRequires
    {
        private readonly IIncompatibleLogger _incompatibleLogger;

        public ClientIncompatibleLoggerAdapter(IIncompatibleLogger incompatibleLogger)
        {
            _incompatibleLogger = incompatibleLogger;
        }

        public void Log(string message)
        {
            _incompatibleLogger.LogToConsole(message);
        }
    }
}
