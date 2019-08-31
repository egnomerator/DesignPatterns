using System.Collections.Generic;
using System.Text;
using static DesignPatterns.Builder.CoffeeDrink;

namespace DesignPatterns.Builder
{
    public abstract class CoffeeBuilder
    {
        protected CoffeeDrink _coffeeDrink;
        protected Dictionary<DrinkSize, int> _sizeToShotsMap;
        protected Dictionary<DrinkSize, int> _sizeToPumpsMap;

        public void StartCoffee(DrinkSize size, bool iced)
        {
            _coffeeDrink = new CoffeeDrink
            {
                Size = size,
                Iced = iced
            };
        }

        public void AddEspresso()
        {
            _coffeeDrink.ShotsEspresso = _sizeToShotsMap[_coffeeDrink.Size];
        }

        public void AddSyrup()
        {
            _coffeeDrink.PumpsSyrup = _sizeToPumpsMap[_coffeeDrink.Size];
        }

        public CoffeeDrink GetCoffee()
        {
            return _coffeeDrink;
        }

        public abstract void SetDrinkName();
        public abstract void AddMilkOrWater();
        public abstract void MapSizeToShots();
        public abstract void MapSizeToPumps();

        public void CreateDescription()
        {
            var icedOrHot = _coffeeDrink.Iced ? "Iced" : "Hot";
            var shots = _coffeeDrink.ShotsEspresso == 1 ? "shot" : "shots";
            var pumps = _coffeeDrink.PumpsSyrup == 1 ? "pump" : "pumps";

            var description = new StringBuilder();
            description.AppendLine($"{_coffeeDrink.Size} {icedOrHot} {_coffeeDrink.DrinkName}:");
            description.AppendLine("\twith:");
            description.AppendLine($"\t\t{_coffeeDrink.ShotsEspresso} {shots} of espresso");
            description.AppendLine($"\t\t{_coffeeDrink.PumpsSyrup} {pumps} of syrup");

            _coffeeDrink.Description = description.ToString();
        }
    }
}
