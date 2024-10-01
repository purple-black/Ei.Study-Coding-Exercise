using UIComponents;
using Factories;
using Utilities;

namespace ApplicationNamespace
{
    public class Application
    {
        private Button _button;
        private Checkbox _checkbox;

        public Application(UIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Render()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}
