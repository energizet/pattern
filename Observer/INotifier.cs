namespace Observer;

public interface INotifier
{
	void AddListener(IListener listener);

	void DeleteListener(IListener listener);

	void Notify();
}