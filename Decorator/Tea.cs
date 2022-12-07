namespace Decorator;

public class Tea : IComponent
{
	public int Price()
	{
		return 50;
	}

	public string Check()
	{
		return "Tea: 50";
	}
}