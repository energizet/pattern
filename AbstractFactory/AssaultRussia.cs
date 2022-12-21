namespace AbstractFactory;

public class AssaultRussia : IAssault
{
	private string _weapon;

	public AssaultRussia(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}