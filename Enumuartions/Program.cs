namespace Enumuartions;

class Program
{
    static void Main(string[] args)
    {
        Temperature temp = new Temperature(TemperatureUnit.Celsius, 45);
        Temperature temp2 = new Temperature(TemperatureUnit.Fahrenheit, 105);
        Temperature temp3 = new Temperature(TemperatureUnit.Kelvin, 300);
        
        temp.GetTemprature();
        Console.WriteLine($"Temp in Celsius: {temp.TemperatureInCelsius}");
        Console.WriteLine($"Temp in Celsius: {temp2.TemperatureInCelsius}");
        Console.WriteLine($"Temp in Celsius: {temp3.TemperatureInCelsius}");
    }
}