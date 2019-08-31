using DesignPatterns.Builder;
using System;
using static DesignPatterns.Builder.CoffeeDrink;

namespace DesignPatterns.PatternDemos
{
    public class BuilderDemo
    {
        public static void Run()
        {
            // Builder Pattern
            //  - a director object which enforces a specific process uses builders
            //  - these builders implement the builder abstraction that the director depends on
            //  - these builders enable variations in details of each step in the process enforced by the director

            var coffeeMaker = new CoffeeMaker();

            var americano = new AmericanoBuilder();
            var latte = new LatteBuilder();
            var flavoredlatte = new FlavoredLatteBuilder();

            var ventiIcedAmericanoOrder = new DrinkOrder(iced: true, DrinkSize.Venti, americano);
            var tallIcedLatteOrder = new DrinkOrder(iced: true, DrinkSize.Tall, latte);
            var grandeHotFlavoredLatteOrder = new DrinkOrder(iced: false, DrinkSize.Grande, flavoredlatte);

            coffeeMaker.AcceptOrder(ventiIcedAmericanoOrder);
            coffeeMaker.BuildCoffee();
            var ventiIcedAmericano = coffeeMaker.GetCoffee();
            Console.WriteLine(ventiIcedAmericano.Description);

            coffeeMaker.AcceptOrder(tallIcedLatteOrder);
            coffeeMaker.BuildCoffee();
            var tallIcedLatte = coffeeMaker.GetCoffee();
            Console.WriteLine(tallIcedLatte.Description);

            coffeeMaker.AcceptOrder(grandeHotFlavoredLatteOrder);
            coffeeMaker.BuildCoffee();
            var grandeHotFlavoredLatte = coffeeMaker.GetCoffee();
            Console.WriteLine(grandeHotFlavoredLatte.Description);
        }
    }
}
