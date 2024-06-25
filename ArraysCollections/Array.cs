namespace ArraysCollections;

public class Array
{
    public int[] MyArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public Array(int FirstParam, int SecondParam)
    {
        MyArray[FirstParam] = SecondParam;
    }

    public void GetArrayDetails(int Position)
    {
        // Console.WriteLine($"The element in position {Position} of the array is {MyArray[Position]}");
        int position = 0;

        foreach (int i in MyArray)
        {
            Console.WriteLine($"The element in position {position+1} of the array is: {i}");
            position++;
        }
    }
}