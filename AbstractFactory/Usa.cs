namespace AbstractFactory;

public class Usa : ICountry
{
	public IAssault GetAssault()
	{
		return new AssaultUsa("m416");
	}

	public IEngineer GetEngineer()
	{
		return new EngineerUsa("spas-12");
	}

	public ISupport GetSupport()
	{
		return new SupportUsa("m249");
	}

	public IRecon GetRecon()
	{
		return new ReconUsa("m417");
	}
}