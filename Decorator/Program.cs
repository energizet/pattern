// See https://aka.ms/new-console-template for more information

using Decorator;

var coffee = new Milk(new Shugar(new Shugar(new Coffee())));
var tea = new Milk(new Tea());

PrintBeverage(coffee);
PrintBeverage(tea);

void PrintBeverage(IComponent beverage)
{
	Console.WriteLine(beverage.Check());
	Console.WriteLine($"Total price: {beverage.Price()}");
	Console.WriteLine();
}