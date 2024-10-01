namespace StructuralBridge.Implementations
{
    public class Radio : IDevice
    {
        public bool IsEnabled { get; set; }
        public int Volume { get; set; } = 30;

        public void Enable()
        {
            IsEnabled = true;
            System.Console.WriteLine("Radio is now ON.");
        }

        public void Disable()
        {
            IsEnabled = false;
            System.Console.WriteLine("Radio is now OFF.");
        }
    }
}
