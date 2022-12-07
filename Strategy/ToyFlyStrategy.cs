namespace Strategy;

public class ToyFlyStrategy : IFlyStrategy
{
	public void Fly()
	{
		Console.WriteLine("Toy fly");
	}
}