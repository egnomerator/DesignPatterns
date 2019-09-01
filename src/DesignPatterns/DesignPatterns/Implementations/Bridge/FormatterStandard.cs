namespace DesignPatterns.Implementations.Bridge
{
    public class FormatterStandard : IFormatter
    {
        public string Format(string title, string message)
        {
            return $"{title}: {message}";
        }
    }
}
