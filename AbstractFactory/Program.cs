using AbstractFactory;

SelectCountry();

void SelectCountry()
{
	Console.WriteLine("1 - USA");
	Console.WriteLine("2 - Russia");
	Console.Write("Enter: ");
	var country = Console.ReadLine();

	switch (country)
	{
		case "1":
			SelectClass(new Usa());
			break;
		case "2":
			SelectClass(new Russia());
			break;
	}
}

void SelectClass(ICountry country)
{
	Console.WriteLine("1 - Assault");
	Console.WriteLine("2 - Engineer");
	Console.WriteLine("3 - Support");
	Console.WriteLine("4 - Recon");
	Console.Write("Enter: ");
	var classId = Console.ReadLine();

	switch (classId)
	{
		case "1":
			PrintWeapon(country.GetAssault());
			break;
		case "2":
			PrintWeapon(country.GetEngineer());
			break;
		case "3":
			PrintWeapon(country.GetSupport());
			break;
		case "4":
			PrintWeapon(country.GetRecon());
			break;
	}
}

void PrintWeapon(IGetWeapon weapon)
{
	Console.WriteLine(weapon.GetWeapon());
}