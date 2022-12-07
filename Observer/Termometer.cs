namespace Observer;

public class Termometer : INotifier
{
	private List<IListener> _listeners = new();
	private int _temp = 0;

	public void SetTemp(int temp)
	{
		_temp = temp;
		Notify();
	}

	public int GetTemp()
	{
		return _temp;
	}

	public void AddListener(IListener listener)
	{
		_listeners.Add(listener);
	}

	public void DeleteListener(IListener listener)
	{
		_listeners.Remove(listener);
	}

	public void Notify()
	{
		foreach (var listener in _listeners)
		{
			listener.Update();
		}
	}
}