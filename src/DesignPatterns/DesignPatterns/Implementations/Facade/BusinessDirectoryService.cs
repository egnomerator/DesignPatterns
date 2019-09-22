using System.Collections.Generic;

namespace DesignPatterns.Implementations.Facade
{
    public class BusinessDirectoryService
    {
        public List<string> GetRestaurantsNearHere(GeoCoordinate location) { return new List<string> { "Un Bien", "Flintcreek Cattle Co.", "The Shambles" }; }

        public List<string> GetGasStationsNearHere(GeoCoordinate location) { return new List<string>(); }

        public List<string> GetHotelsNearHere(GeoCoordinate location) { return new List<string>(); }
    }
}
