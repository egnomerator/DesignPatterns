using System.Collections.Generic;

namespace DesignPatterns.Implementations.Facade
{
    public class LocalRestaurantFinder
    {
        private readonly LocalizationService _localizationService;
        private readonly BusinessDirectoryService _businessDirectoryService;

        public LocalRestaurantFinder()
        {
            _localizationService = new LocalizationService();
            _businessDirectoryService = new BusinessDirectoryService();
        }

        public List<string> GetLocalRestaurants()
        {
            var location = _localizationService.GetExactLocation();

            return _businessDirectoryService.GetRestaurantsNearHere(location);
        }

        public string GetCurrentCity()
        {
            return _localizationService.GetCity();
        }
    }
}
