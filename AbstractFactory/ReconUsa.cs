namespace AbstractFactory;

public class ReconUsa : IRecon
{
	private string _weapon;

	public ReconUsa(string weapon)
	{
		_weapon = weapon;
	}

	public string GetWeapon()
	{
		return _weapon;
	}
}