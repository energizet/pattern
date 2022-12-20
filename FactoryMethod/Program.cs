// See https://aka.ms/new-console-template for more information

using FactoryMethod;

PrintFruits(new OptimalFruitFactory(), 6);
Console.WriteLine();
PrintFruits(new RandomFruitFactory(), 6);

void PrintFruits(IFruitFactory factory, int n)
{
	for (var i = 0; i < n; i++)
	{
		Console.WriteLine(factory.Create().GetName());
	}
}