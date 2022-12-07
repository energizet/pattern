namespace Decorator;

public class Coffee : IComponent
{
	public int Price()
	{
		return 60;
	}

	public string Check()
	{
		return "Coffee: 60";
	}
}