namespace DesignPatterns.Implementations.Command
{
    public class SimpleSoundBarController
    {
        private readonly ICommand _power;
        private readonly ICommand _mute;
        private readonly ICommand _increaseVolume;
        private readonly ICommand _decreaseVolume;

        public SimpleSoundBarController(ICommand power, ICommand mute, ICommand increaseVolume, ICommand decreaseVolume)
        {
            _power = power;
            _mute = mute;
            _increaseVolume = increaseVolume;
            _decreaseVolume = decreaseVolume;
        }

        public void Power()
        {
            _power.Execute();
        }

        public void Mute()
        {
            _mute.Execute();
        }

        public void IncreaseVolume()
        {
            _increaseVolume.Execute();
        }

        public void DecreaseVolume()
        {
            _decreaseVolume.Execute();
        }
    }
}
