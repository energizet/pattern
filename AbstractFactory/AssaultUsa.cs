namespace AbstractFactory;

public class AssaultUsa : IAssault
{
	private string _weapon;

	public AssaultUsa(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}