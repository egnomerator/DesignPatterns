namespace DesignPatterns.Implementations.Factory.Method
{
    public class KnightFactory : FighterFactory
    {
        public override IFighter CreateFighter()
        {
            return new Knight();
        }
    }
}
