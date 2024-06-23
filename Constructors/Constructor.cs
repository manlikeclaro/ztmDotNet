namespace Constructors;

public class Constructor
{
    public Constructor(string? nameParam = null)
    {
        Name = nameParam;
    }

    public string Name { get; private set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}! How is your day coming?");
    }

    public string GetGreeting()
    {
        return $"Hello, {Name}! How is your day coming?";
    }
}