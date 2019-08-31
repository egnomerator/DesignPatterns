using System.Collections.Generic;
using static DesignPatterns.Builder.CoffeeDrink;

namespace DesignPatterns.Builder
{
    public class LatteBuilder : CoffeeBuilder
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
                {DrinkSize.Tall, 0},
                {DrinkSize.Grande, 0},
                {DrinkSize.Venti, 0}
            };
        }

        public override void SetDrinkName()
        {
            _coffeeDrink.DrinkName = "Latte";
        }
    }
}
