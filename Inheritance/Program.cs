namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John Kamau", "Software Engineer", 
            "Senior", "Caltex Solutions");
        employee.GetEmployeeDetails();
        employee.GetPersonDetails();
    }
}