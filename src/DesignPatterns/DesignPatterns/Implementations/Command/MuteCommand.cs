namespace DesignPatterns.Implementations.Command
{
    public class MuteCommand : ICommand
    {
        private readonly SimpleSoundBar _simpleSoundBar;

        public MuteCommand(SimpleSoundBar simpleSoundBar)
        {
            _simpleSoundBar = simpleSoundBar;
        }

        public void Execute()
        {
            _simpleSoundBar.Mute();
        }
    }
}
