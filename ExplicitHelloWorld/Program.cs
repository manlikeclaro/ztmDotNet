namespace ExplicitHelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a name of a variable: ");
        int? nameOfVariable = int.Parse(Console.ReadLine());

        SecondClass hello = new SecondClass(variable2: Convert.ToString(nameOfVariable), variable1: "mkmkmk");
        hello.newFunct();
        Console.ReadKey();
    }
}