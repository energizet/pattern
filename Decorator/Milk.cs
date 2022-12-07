namespace Decorator;

public class Milk : BaseAddition
{
	public Milk(IComponent inner) : base(inner)
	{
	}

	public override int Price()
	{
		return GetInner().Price() + 20;
	}

	public override string Check()
	{
		return $"{GetInner().Check()}\nMilk: 20";
	}
}