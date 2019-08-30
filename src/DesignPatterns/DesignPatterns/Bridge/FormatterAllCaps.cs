namespace DesignPatterns.Bridge
{
    public class FormatterAllCaps : IFormatter
    {
        public string Format(string title, string message)
        {
            return $"{title.ToUpper()}: {message.ToUpper()}";
        }
    }
}
