using System.Collections.Generic;
using static DesignPatterns.Implementations.Builder.CoffeeDrink;

namespace DesignPatterns.Implementations.Builder
{
    public class AmericanoBuilder : CoffeeBuilder
    {
        public override void AddMilkOrWater()
        {
            _coffeeDrink.MilkOrWater = MilkWater.Water;
        }

        public override void MapSizeToShots()
        {
            _sizeToShotsMap = new Dictionary<DrinkSize, int>
            {
                {DrinkSize.Tall, 2},
                {DrinkSize.Grande, 3},
                {DrinkSize.Venti, 4}
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
            _coffeeDrink.DrinkName = "Americano";
        }
    }
}
