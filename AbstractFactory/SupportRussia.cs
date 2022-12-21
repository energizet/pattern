namespace AbstractFactory;

public class SupportRussia : ISupport
{
	private string _weapon;

	public SupportRussia(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}