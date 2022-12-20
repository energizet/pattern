// See https://aka.ms/new-console-template for more information

using Builder;

var car = new Car("V8","Mizhlen","KuriTo");

Console.WriteLine(car);

car = new CarBuilder()
	.SetEngine("Disel")
	.SetWheels("От жигулей")
	.SetKuzov("ржавчина")
	.Build();

Console.WriteLine(car);
