using UIComponents;

namespace Factories
{
    public abstract class UIFactory
    {
        public abstract Button CreateButton();
        public abstract Checkbox CreateCheckbox();
    }
}
