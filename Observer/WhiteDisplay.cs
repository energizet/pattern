namespace Observer;

public class WhiteDisplay : IListener
{
	private Termometer _termometer;
	private int _number;

	public WhiteDisplay(Termometer termometer)
	{
		_number = IListener.numbers++;
		_termometer = termometer;
		_termometer.AddListener(this);
	}

	public void Update()
	{
		Console.CursorLeft = Console.WindowWidth / 2 - 9;
		(var back, var front) = (Console.BackgroundColor, Console.ForegroundColor);
		(Console.BackgroundColor, Console.ForegroundColor) = (ConsoleColor.Blue, ConsoleColor.Black);
		Console.Write($"Diplay: {_number}, Temp: {_termometer.GetTemp()}");
		(Console.BackgroundColor, Console.ForegroundColor) = (back, front);
		Console.Write(new string(' ', 10));
		Console.WriteLine();
	}
}