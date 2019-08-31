using static DesignPatterns.Builder.CoffeeDrink;

namespace DesignPatterns.Builder
{
    public class DrinkOrder
    {
        public bool Iced { get; }
        public DrinkSize DrinkSize { get; }
        public CoffeeBuilder Drink { get; }

        public DrinkOrder(bool iced, DrinkSize drinkSize, CoffeeBuilder drink)
        {
            Iced = iced;
            DrinkSize = drinkSize;
            Drink = drink;
        }
    }
}
