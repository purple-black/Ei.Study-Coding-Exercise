using StructuralBridge.Implementations;

namespace StructuralBridge.Abstractions
{
    public class BasicRemote : IRemote
    {
        private readonly IDevice _device;

        public BasicRemote(IDevice device)
        {
            _device = device;
        }

        public void Power()
        {
            if (_device.IsEnabled)
                _device.Disable();
            else
                _device.Enable();
        }

        public void VolumeUp()
        {
            _device.Volume += 10;
            System.Console.WriteLine($"Volume increased to {_device.Volume}.");
        }

        public void VolumeDown()
        {
            _device.Volume -= 10;
            System.Console.WriteLine($"Volume decreased to {_device.Volume}.");
        }

        public void Mute()
        {
            System.Console.WriteLine("Mute not supported in Basic Remote.");
        }
    }
}
