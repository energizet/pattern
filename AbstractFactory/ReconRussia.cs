namespace AbstractFactory;

public class ReconRussia : IRecon
{
	private string _weapon;

	public ReconRussia(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}