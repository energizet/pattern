// See https://aka.ms/new-console-template for more information

using Observer;

var termometer = new Termometer();

var list = new List<IListener>
{
	new Display(termometer),
	new WhiteDisplay(termometer),
	new WhiteDisplay(termometer),
	new RedDisplay(termometer),
	new RedDisplay(termometer),
	new Display(termometer),
};

termometer.DeleteListener(list[0]);
termometer.DeleteListener(list[5]);

Console.CursorVisible = false;
var task = Task.Run(async () =>
{
	var rand = new Random();
	while (true)
	{
		Console.CursorLeft = Console.WindowWidth / 2 - 9;
		Console.CursorTop = Console.WindowHeight / 2 - 2;
		termometer.SetTemp(rand.Next(-20, 40));
		await Task.Delay(2000);
	}
});

Task.WaitAll(task);