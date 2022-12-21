namespace AbstractFactory;

public class EngineerRussia : IEngineer
{
	private string _weapon;

	public EngineerRussia(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}