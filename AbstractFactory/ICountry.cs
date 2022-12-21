namespace AbstractFactory;

public interface ICountry
{
	IAssault GetAssault();
	IEngineer GetEngineer();
	ISupport GetSupport();
	IRecon GetRecon();
}