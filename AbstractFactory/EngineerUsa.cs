namespace AbstractFactory;

public class EngineerUsa : IEngineer
{
	private string _weapon;

	public EngineerUsa(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}