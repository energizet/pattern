namespace Builder;

public class CarBuilder
{
	private string Engine;
	private string Wheels;
	private string KuzOV;


	public CarBuilder SetEngine(string engine)
	{
		Engine = engine;
		return this;
	}

	public CarBuilder SetWheels(string wheels)
	{
		Wheels = wheels;
		return this;
	}

	public CarBuilder SetKuzov(string kuzov)
	{
		KuzOV = kuzov;
		return this;
	}

	public Car Build()
	{
		return new Car(Engine, Wheels, KuzOV);
	}
}