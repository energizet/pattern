namespace Strategy;

public class Duck
{
	private string _display;
	private IFlyStrategy _flyStrategy;
	private ICrakkStrategy _crakkStrategy;

	public Duck(string display, IFlyStrategy flyStrategy, ICrakkStrategy crakkStrategy)
	{
		_flyStrategy = flyStrategy;
		_crakkStrategy = crakkStrategy;
		_display = display;
	}

	public void Display()
	{
		Console.WriteLine(_display);
	}

	public void Fly()
	{
		_flyStrategy.Fly();
	}

	public void Crakk()
	{
		_crakkStrategy.Crakk();
	}
}