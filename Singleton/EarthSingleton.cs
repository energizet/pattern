namespace Singleton;

public class EarthSingleton
{
	private static EarthSingleton s_singleton;
	private Earth _earth;

	private EarthSingleton(Earth earth)
	{
		_earth = earth;
	}

	public static Earth GetEarth()
	{
		if (s_singleton == null)
		{
			s_singleton = new EarthSingleton(new Earth());
		}

		return s_singleton._earth;
	}
}