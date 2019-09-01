using DesignPatterns.Implementations.Bridge;

namespace DesignPatterns.Demos
{
    public class Bridge
    {
        public static void Run()
        {
            // Bridge Pattern allows independent variation between abstraction (logger) and implementation (formatting functionality)

            var standardFormatter = new FormatterStandard();
            var allCapsFormatter = new FormatterAllCaps();

            var consoleLoggerInStandardFormat = new LoggerConsole(standardFormatter);
            var consoleLoggerInAllCaps = new LoggerConsole(allCapsFormatter);

            var fileLoggerInStandardFormat = new LoggerFile(standardFormatter);
            var fileLoggerInAllCaps = new LoggerFile(allCapsFormatter);

            const string title = "The Title";
            const string message = "This is the message.";

            consoleLoggerInStandardFormat.Log(title, message);
            consoleLoggerInAllCaps.Log(title, message);
            fileLoggerInStandardFormat.Log(title, message);
            fileLoggerInAllCaps.Log(title, message);
        }
    }
}
