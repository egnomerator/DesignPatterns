namespace DesignPatterns.Implementations.Builder
{
    public class CoffeeDrink
    {
        public string DrinkName { get; set; }
        public DrinkSize Size { get; set; }
        public bool Iced { get; set; }
        public MilkWater MilkOrWater { get; set; }
        public int ShotsEspresso { get; set; }
        public int PumpsSyrup { get; set; }
        public string Description { get; set; }

        public enum DrinkSize
        {
            Tall,
            Grande,
            Venti
        }

        public enum MilkWater
        {
            Milk,
            Water
        }
    }
}
