namespace Decorator;

public class Shugar : BaseAddition
{
	public Shugar(IComponent inner) : base(inner)
	{
	}

	public override int Price()
	{
		return GetInner().Price() + 10;
	}

	public override string Check()
	{
		return $"{GetInner().Check()}\nShugar: 10";
	}
}