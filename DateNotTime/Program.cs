using System.Globalization;

namespace DateNotTime;

class Program
{
    static void Main(string[] args)
    {
        DateTime localDate = new DateTime(2008,2,12);
        DateTime usDate = DateTime.Parse("06/22/2024");
        DateTime keDate = DateTime.Parse("22/06/2024", new CultureInfo("en-KE"));
        DateTime now = DateTime.UtcNow;
        
        Console.WriteLine($"local time {localDate}, us time {usDate}, ke time {keDate}");
        Console.WriteLine(now.ToString(new CultureInfo("en-KE")));
        Console.WriteLine(now.ToString("D"));
    }
}