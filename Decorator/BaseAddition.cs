namespace Decorator;

public abstract class BaseAddition : IComponent
{
	private readonly IComponent _inner;

	protected BaseAddition(IComponent inner)
	{
		_inner = inner;
	}

	protected IComponent GetInner()
	{
		return _inner;
	}

	public abstract int Price();

	public abstract string Check();
}