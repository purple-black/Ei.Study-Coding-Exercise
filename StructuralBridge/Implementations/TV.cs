namespace StructuralBridge.Implementations
{
    public class TV : IDevice
    {
        public bool IsEnabled { get; set; }
        public int Volume { get; set; } = 50;

        public void Enable()
        {
            IsEnabled = true;
            System.Console.WriteLine("TV is now ON.");
        }

        public void Disable()
        {
            IsEnabled = false;
            System.Console.WriteLine("TV is now OFF.");
        }
    }
}
