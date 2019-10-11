namespace DesignPatterns.Implementations.Factory.Abstract
{
    public abstract class Barracks
    {
        public abstract IFighter TrainMelee();
        public abstract IFighter TrainRanged();
    }
}
