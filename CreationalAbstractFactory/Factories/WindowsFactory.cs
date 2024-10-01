using UIComponents;

namespace Factories
{
    public class WindowsFactory : UIFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }

        public override Checkbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
