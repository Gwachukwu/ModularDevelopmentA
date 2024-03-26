using DecoratorDesignPatternConsole.Interfaces;

namespace DecoratorDesignPatternConsole.Classes
{
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        {

        }
        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }
}