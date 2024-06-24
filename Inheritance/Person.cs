namespace Inheritance;

public class Person
{
    public string name { get; set; }
    public string profession { get; set; }
    
    public Person(string nameParam, string professionParam)
    {
        name = nameParam;
        profession = professionParam;
    }

    public virtual void GetPersonDetails()
    {
        Console.WriteLine($"{name} - {profession}");
    }
}