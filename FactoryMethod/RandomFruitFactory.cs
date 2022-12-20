namespace FactoryMethod;

public class RandomFruitFactory : IFruitFactory
{
	private readonly Random _random = new();

	public IFruit Create()
	{
		return _random.Next(3) switch
		{
			0 => new Apple(),
			1 => new Banana(),
			_ => new Orange(),
		};
	}
}