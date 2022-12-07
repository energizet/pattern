// See https://aka.ms/new-console-template for more information

using Singleton;

var earth = EarthSingleton.GetEarth();
earth.Continents.Add("Australia");

Console.WriteLine(string.Join(", ", earth.Continents));