namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        ICar tesla = new Vehicle("Tesla Model S", 256);
        Console.WriteLine($"{tesla.GetModel()}, it's top speed is {tesla.GetTopSpeed()} km/h!");
    }
}