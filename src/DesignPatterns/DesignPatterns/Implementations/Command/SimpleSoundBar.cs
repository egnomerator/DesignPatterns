using System;

namespace DesignPatterns.Implementations.Command
{
    public class SimpleSoundBar
    {
        public const string PowerNeeded = "Turn power on first.";
        private readonly int _minVolume = 0;
        private readonly int _maxVolume = 10;
        private int _volume = 5;
        public bool PowerOn { get; set; }
        public bool Muted { get; set; }
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < _minVolume || value > _maxVolume) return;
                _volume = value;
            }
        }

        public static SimpleSoundBar Singleton { get; } = new SimpleSoundBar();

        private SimpleSoundBar() { }

        public void Power()
        {
            PowerOn = !PowerOn;

            if (PowerOn) Console.WriteLine("Power On");
            else Console.WriteLine("Power Off");
        }

        public void Mute()
        {
            if (NotifiedPowerNeededFirst()) return;

            Muted = !Muted;
            if (Muted) Console.WriteLine("Muted");
            else Console.WriteLine("Un-muted");
        }

        public void IncreaseVolume()
        {
            if (NotifiedPowerNeededFirst()) return;

            Volume++;
            Console.WriteLine($"Volume increased to {Volume}");
        }

        public void DecreaseVolume()
        {
            if (NotifiedPowerNeededFirst()) return;

            Volume--;
            Console.WriteLine($"Volume decreased to {Volume}");
        }

        private bool NotifiedPowerNeededFirst()
        {
            if (PowerOn) return false;

            Console.WriteLine(PowerNeeded);
            return true;
        }
    }
}
