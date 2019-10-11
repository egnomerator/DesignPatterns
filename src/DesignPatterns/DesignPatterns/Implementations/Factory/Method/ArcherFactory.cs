namespace DesignPatterns.Implementations.Factory.Method
{
    public class ArcherFactory : FighterFactory
    {
        public override IFighter CreateFighter()
        {
            return new Archer();
        }
    }
}
