namespace Builder;

public class Car
{
	private string Engine;
	private string Wheels;
	private string KuzOV;

	public Car(string engine, string wheels, string kuzOv)
	{
		Engine = engine;
		Wheels = wheels;
		KuzOV = kuzOv;
	}

	public override string ToString()
	{
		return $"{Engine} {Wheels} {KuzOV}";
	}
}