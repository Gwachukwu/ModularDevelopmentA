using DecoratorDesignPatternConsole.Interfaces;

namespace DecoratorDesignPatternConsole.Classes
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hello World.";
        }
    }
}