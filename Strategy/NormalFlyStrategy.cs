namespace Strategy;

public class NormalFlyStrategy : IFlyStrategy
{
	public void Fly()
	{
		Console.WriteLine("Normal fly");
	}
}