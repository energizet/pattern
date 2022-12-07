namespace Observer;

public class Display : IListener
{
	private static int numbers = 0;
	
	private Termometer _termometer;
	private int _number;

	public Display(Termometer termometer)
	{
		_number = IListener.numbers++;
		_termometer = termometer;
		_termometer.AddListener(this);
	}

	public void Update()
	{
		Console.CursorLeft = Console.WindowWidth / 2 - 9;
		Console.Write($"Diplay: {_number}, Temp: {_termometer.GetTemp()}");
		Console.Write(new string(' ', 10));
		Console.WriteLine();
	}
}