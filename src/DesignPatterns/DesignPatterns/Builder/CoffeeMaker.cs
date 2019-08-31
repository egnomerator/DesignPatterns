namespace DesignPatterns.Builder
{
    public class CoffeeMaker
    {
        public CoffeeBuilder _coffeeBuilder;

        public void AcceptOrder(DrinkOrder drinkOrder)
        {
            _coffeeBuilder = drinkOrder.Drink;

            _coffeeBuilder.StartCoffee(drinkOrder.DrinkSize, drinkOrder.Iced);
            _coffeeBuilder.MapSizeToShots();
            _coffeeBuilder.MapSizeToPumps();
        }

        public void BuildCoffee()
        {
            _coffeeBuilder.AddEspresso();
            _coffeeBuilder.AddMilkOrWater();
            _coffeeBuilder.AddSyrup();
        }

        public CoffeeDrink GetCoffee()
        {
            _coffeeBuilder.SetDrinkName();
            _coffeeBuilder.CreateDescription();
            return _coffeeBuilder.GetCoffee();
        }
    }
}
