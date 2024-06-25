namespace ArraysCollections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Enter a number you want to add to the array: ");
        int ArrayElement = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter the position in the array: ");
        int ElementPosition = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            Array Element = new Array(ElementPosition, ArrayElement);
            Element.GetArrayDetails(ElementPosition);
            // Element.GetArrayDetails(10);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            // throw;
        }
    }
}