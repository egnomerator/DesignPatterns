namespace DesignPatterns.Implementations.Facade
{
    public class LocalizationService
    {
        public GeoCoordinate GetExactLocation() { return new GeoCoordinate(); }

        public string GetCity() { return "Seattle"; }

        public string GetCityState() { return default; }

        public double GetHeading() { return default; }
    }
}
