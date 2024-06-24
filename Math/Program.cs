namespace Math;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value of the first number: ");
        long num1 = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter value of the second number: ");
        long num2 = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine($"The sum of the two numbers is: {Math.AddNums(num1, num2)}");
        Console.WriteLine($"The difference of the two numbers is: {Math.SubtractNums(num1, num2)}");
        Console.WriteLine($"The multiplication of the two numbers is: {Math.MultiplyNums(num1, num2)}");
        Console.WriteLine($"The division of the two numbers is: {Math.DivideNums(num1, num2)}");
        
        Console.WriteLine($"The circumference is {Math.PI * (num1*num1)}");
    }
}