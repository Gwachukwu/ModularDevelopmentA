using DecoratorDesignPatternConsole.Classes;
using DecoratorDesignPatternConsole.Interfaces;

IComponent<string> concreteComponent = new ConcreteComponent();
ColorDecorator colorDecorator = new(concreteComponent);
PlainDecorator plainDecorator = new(concreteComponent);
UpperCaseDecorator UpperCaseDecorator = new(concreteComponent);

Console.WriteLine(concreteComponent.GetText());
Console.WriteLine(colorDecorator.GetText());
Console.WriteLine(plainDecorator.GetText());
Console.WriteLine(UpperCaseDecorator.GetText());
