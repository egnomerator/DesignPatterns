namespace DesignPatterns.Implementations.Factory.Abstract
{
    public class HumanBarracks : Barracks
    {
        public override IFighter TrainMelee()
        {
            return new Knight();
        }

        public override IFighter TrainRanged()
        {
            return new Archer();
        }
    }
}
