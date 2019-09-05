using DesignPatterns.Implementations.Command;

namespace DesignPatterns.Demos
{
    public class Command
    {
        public static void Run()
        {
            var simpleSoundBar = SimpleSoundBar.Singleton;

            var powerCommand = new PowerCommand(simpleSoundBar);
            var muteCommand = new MuteCommand(simpleSoundBar);
            var increaseVolumeCommand = new IncreaseVolumeCommand(simpleSoundBar);
            var decreaseVolumeCommand = new DecreaseVolumeCommand(simpleSoundBar);

            var controller = new SimpleSoundBarController(powerCommand, muteCommand, increaseVolumeCommand, decreaseVolumeCommand);

            controller.Mute(); // should result in message "Turn power on first."
            controller.Power();
            controller.IncreaseVolume();
            controller.IncreaseVolume();
            controller.Mute();
            controller.Mute();
            controller.DecreaseVolume();
            controller.Power();
        }
    }
}
