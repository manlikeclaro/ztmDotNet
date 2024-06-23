namespace ExplicitHelloWorld;

public class SecondClass
{
    public string? newString;
    public string? newString2;

    public SecondClass(string? variable1 = null, string? variable2 = null)
    {
        newString = variable1;
        newString2 = variable2;
    }

    public void newFunct()
    {
        // newString = stringParam;
        Console.WriteLine($"The name of the string2 is {newString2} but string1 is {newString}");
    }
}