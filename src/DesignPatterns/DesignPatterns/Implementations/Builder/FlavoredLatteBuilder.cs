using System.Collections.Generic;
using static DesignPatterns.Implementations.Builder.CoffeeDrink;

namespace DesignPatterns.Implementations.Builder
{
    public class FlavoredLatteBuilder : CoffeeBuilder
    {
        public override void AddMilkOrWater()
        {
            _coffeeDrink.MilkOrWater = MilkWater.Milk;
        }

        public override void MapSizeToShots()
        {
            _sizeToShotsMap = new Dictionary<DrinkSize, int>
            {
                {DrinkSize.Tall, 1},
                {DrinkSize.Grande, 2},
                {DrinkSize.Venti, 2}
            };
        }

        public override void MapSizeToPumps()
        {
            _sizeToPumpsMap = new Dictionary<DrinkSize, int>
            {
                {DrinkSize.Tall, 3},
                {DrinkSize.Grande, 4},
                {DrinkSize.Venti, 5}
            };
        }

        public override void SetDrinkName()
        {
            _coffeeDrink.DrinkName = "Flavored Latte";
        }
    }
}
