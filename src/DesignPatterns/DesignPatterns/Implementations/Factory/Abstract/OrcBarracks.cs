namespace DesignPatterns.Implementations.Factory.Abstract
{
    public class OrcBarracks : Barracks
    {
        public override IFighter TrainMelee()
        {
            return new Grunt();
        }

        public override IFighter TrainRanged()
        {
            return new AxeThrower();
        }
    }
}
