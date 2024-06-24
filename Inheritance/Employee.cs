namespace Inheritance;

public class Employee : Person
{
    public string role { get; set; }
    public string organization { get; set; }

    public Employee(string nameParam, string professionParam, string roleParam, string organizationParam) : 
        base(nameParam, professionParam)
    {
        role = roleParam;
        organization = organizationParam;
    }

    public void GetEmployeeDetails()
    {
        Console.WriteLine($"{name} is a {profession} working at {organization} as a {role}");
    }

    public override void GetPersonDetails()
    {
        string overridden = $"{name} !!!!!!!!!!!!!!!!!";
        Console.WriteLine(overridden);
    }
}