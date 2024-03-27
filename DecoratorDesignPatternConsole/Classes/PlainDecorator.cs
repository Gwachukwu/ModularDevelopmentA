namespace DecoratorDesignPatternConsole.Classes;

using DecoratorDesignPatternConsole.Interfaces;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> component) : base(component)
    {

    }
    public override string GetText()
    {
        return "My name is Gwachukwu. " + base.GetText();
    }
}
