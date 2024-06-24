namespace Enumuartions;

public class Temperature
{
    public Temperature(TemperatureUnit temperatureUnitParam, decimal valueParam)
    {
        Unit = temperatureUnitParam;
        Value = valueParam;
    }
    
    public TemperatureUnit Unit { get; }
    public decimal Value { get; }

    public void GetTemprature()
    {
        Console.WriteLine($"The temperature reading is {Value} degrees {Unit}");
    }

    public decimal TemperatureInCelsius
    {
        get
        {
            switch (Unit)
            {
                case TemperatureUnit.Celsius:
                    return Value;
                case TemperatureUnit.Fahrenheit:
                    return (Value - 32) * 5/9;
                case TemperatureUnit.Kelvin:
                    return Value - 273.15m;
                default:
                    return 0;
            }
        }
    }
}