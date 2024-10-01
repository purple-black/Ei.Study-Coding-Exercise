using UIComponents;

namespace Factories
{
    public class MacOSFactory : UIFactory
    {
        public override Button CreateButton()
        {
            return new MacOSButton();
        }

        public override Checkbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }
    }
}
