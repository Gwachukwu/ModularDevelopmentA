using DecoratorDesignPatternConsole.Classes;
using DecoratorDesignPatternConsole.Interfaces;

IComponent<string> concreteComponent = new ConcreteComponent();
IComponent<string> colorDecorator = new ColorDecorator(concreteComponent);
IComponent<string> plainDecorator = new PlainDecorator(concreteComponent);
IComponent<string> UpperCaseDecorator = new UpperCaseDecorator(concreteComponent);

Console.WriteLine(concreteComponent.GetText());
Console.WriteLine(colorDecorator.GetText());
Console.WriteLine(plainDecorator.GetText());
Console.WriteLine(UpperCaseDecorator.GetText());
