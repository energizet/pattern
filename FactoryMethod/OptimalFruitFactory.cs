namespace FactoryMethod;

public class OptimalFruitFactory : IFruitFactory
{
	private IEnumerator<IFruit>? _enumerator = null;

	private readonly Func<IFruit>[] _fruits =
	{
		() => new Apple(),
		() => new Banana(),
		() => new Orange()
	};

	public IFruit Create()
	{
		if (_enumerator == null || _enumerator.MoveNext() == false)
		{
			_enumerator = GetFruits().GetEnumerator();
			_enumerator.MoveNext();
		}

		return _enumerator.Current;
	}

	private IEnumerable<IFruit> GetFruits()
	{
		var fruits = _fruits.ToList();
		var rand = new Random();

		while (fruits.Count > 0)
		{
			var index = rand.Next(fruits.Count);
			yield return fruits[index]();
			fruits.RemoveAt(index);
		}
	}
}