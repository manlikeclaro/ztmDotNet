namespace Interfaces;

public class Vehicle : ICar
{
    public string model;
    public int topSpeed;

    public Vehicle(string modelParam, int topSpeedParam)
    {
        model = modelParam;
        topSpeed = topSpeedParam;
    }

    public string GetModel()
    {
        return $"The car is a {model}";
    }

    public int GetTopSpeed()
    {
        return topSpeed;
    }
}