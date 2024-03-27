namespace DecoratorDesignPatternConsole.Classes;

using DecoratorDesignPatternConsole.Interfaces;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Hello World.";
    }
}
