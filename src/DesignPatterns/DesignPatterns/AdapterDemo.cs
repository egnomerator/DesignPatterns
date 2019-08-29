using DesignPatterns.Adapter;

namespace DesignPatterns
{
    public class AdapterDemo
    {
        public static void Run()
        {
            // The Scenario:
            //
            //  - we have a Client class that requires something that implements ILoggerClientRequires (we want the Client to call the Log method)
            //  - but the Client needs the functionality of the IncompatibleLogger which implements a different interface, IIncompatibleLogger (which provides a LogToConsole method)
            //
            // The Solution - Adapter Pattern:
            //
            //  - Create the ClientIncompatibleLoggerAdapter which implements ILoggerClientRequires so the Client can use it
            //      - ClientIncompatibleLoggerAdapter requires an implementation of IIncompatibleLogger (to use on behalf of the Client)
            //  - Pass the ClientIncompatibleLoggerAdapter to the Client
            //  - Now the Client can call the expected Log method implemented by ClientIncompatibleLoggerAdapter
            //      - when the Client calls the Log method on the adapter, the adapter calls the LogToConsole method on the stored IIncompatibleLogger
            //
            // Result
            //  - the Client is able to use the interface it requires and, thanks to the adapter, is able to use the functionality it needed from the
            //    incompatible interface

            var incompatibleLogger = new IncompatibleLogger();
            var loggerAdapter = new ClientIncompatibleLoggerAdapter(incompatibleLogger);
            var client = new Client(loggerAdapter);

            client.Log("I'm using the logger I require!");
        }
    }
}
