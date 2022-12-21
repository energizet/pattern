namespace AbstractFactory;

public class SupportUsa : ISupport
{
	private string _weapon;

	public SupportUsa(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}