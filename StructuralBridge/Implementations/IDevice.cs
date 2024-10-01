namespace StructuralBridge.Implementations
{
    public interface IDevice
    {
        bool IsEnabled { get; set; }
        int Volume { get; set; }

        void Enable();
        void Disable();
    }
}
