namespace DecoratorDesignPatternConsole.Interfaces
{
    public interface IComponent<T>
    {
        T GetText();
    }
}