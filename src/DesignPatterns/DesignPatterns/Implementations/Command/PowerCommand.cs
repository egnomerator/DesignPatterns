namespace DesignPatterns.Implementations.Command
{
    public class PowerCommand : ICommand
    {
        private readonly SimpleSoundBar _simpleSoundBar;

        public PowerCommand(SimpleSoundBar simpleSoundBar)
        {
            _simpleSoundBar = simpleSoundBar;
        }

        public void Execute()
        {
            _simpleSoundBar.Power();
        }
    }
}
