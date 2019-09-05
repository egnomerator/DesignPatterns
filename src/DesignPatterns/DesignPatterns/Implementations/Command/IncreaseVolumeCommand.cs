namespace DesignPatterns.Implementations.Command
{
    public class IncreaseVolumeCommand : ICommand
    {
        private readonly SimpleSoundBar _simpleSoundBar;

        public IncreaseVolumeCommand(SimpleSoundBar simpleSoundBar)
        {
            _simpleSoundBar = simpleSoundBar;
        }

        public void Execute()
        {
            _simpleSoundBar.IncreaseVolume();
        }
    }
}
