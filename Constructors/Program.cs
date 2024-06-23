namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        Constructor newInstance = new Constructor("John");
        newInstance.PrintGreeting();
        string greeting = newInstance.GetGreeting();
        Console.WriteLine($"{greeting} - Message from method");
        // string greeting = newInstance.GetGreeting();
        Console.WriteLine(newInstance.GetGreeting() + " Message from method as well");
    }
}