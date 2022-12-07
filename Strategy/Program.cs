// See https://aka.ms/new-console-template for more information

using Strategy;

class Program
{
	public static void Main()
	{
		var normalDuck = CreateNormalDuck();
		var toyDuck = CreateToyDuck();
		var toyJetDuck = CreateToyJetDuck();
		
		PrintDuck(normalDuck);
		PrintDuck(toyDuck);
		PrintDuck(toyJetDuck);
	}

	static void PrintDuck(Duck duck)
	{
		duck.Display();
		duck.Fly();
		duck.Crakk();
		Console.WriteLine();
	}

	static Duck CreateNormalDuck()
	{
		return new Duck("Normal Duck", new NormalFlyStrategy(), new NormalCrakkStrategy());
	}

	static Duck CreateToyDuck()
	{
		return new Duck("Toy Duck", new ToyFlyStrategy(), new ToyCrakkStrategy());
	}

	static Duck CreateToyJetDuck()
	{
		return new Duck("Toy Jet Duck", new JeyFlyStrategy(), new ToyCrakkStrategy());
	}
}