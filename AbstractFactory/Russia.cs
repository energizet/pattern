namespace AbstractFactory;

public class Russia : ICountry
{
	public IAssault GetAssault()
	{
		return new AssaultRussia("ак74");
	}

	public IEngineer GetEngineer()
	{
		return new EngineerRussia("сайга-12");
	}

	public ISupport GetSupport()
	{
		return new SupportRussia("рпк");
	}

	public IRecon GetRecon()
	{
		return new ReconRussia("свд");
	}
}