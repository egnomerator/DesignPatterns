using DesignPatterns.Adapter;

namespace DesignPatterns
{
    public class AdapterDemo
    {
        public static void Run()
        {
            var incompatibleLogger = new IncompatibleLogger();

            var loggerAdapter = new ClientIncompatibleLoggerAdapter(incompatibleLogger);
            var client = new Client(loggerAdapter);

            client.Log("I'm using the logger I require!");
        }
    }
}
