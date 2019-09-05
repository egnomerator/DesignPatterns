namespace DesignPatterns.Implementations.Command
{
    public class DecreaseVolumeCommand : ICommand
    {
        private readonly SimpleSoundBar _simpleSoundBar;

        public DecreaseVolumeCommand(SimpleSoundBar simpleSoundBar)
        {
            _simpleSoundBar = simpleSoundBar;
        }

        public void Execute()
        {
            _simpleSoundBar.DecreaseVolume();
        }
    }
}
