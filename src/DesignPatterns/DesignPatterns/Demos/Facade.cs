using DesignPatterns.Implementations.Facade;
using System;

namespace DesignPatterns.Demos
{
    public class Facade
    {
        public static void Run()
        {
            var restaurantFinder = new LocalRestaurantFinder();
            var city = restaurantFinder.GetCurrentCity();
            var localRestaurants = restaurantFinder.GetLocalRestaurants();

            var listing = string.Join(", ", localRestaurants);
            Console.Write($"Local Restaurants ({city}): {listing}");
        }
    }
}
