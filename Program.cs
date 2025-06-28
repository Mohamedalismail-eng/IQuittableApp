using System;

// Define an interface called IQuittable
public interface IQuittable
{
    // Define a method signature for Quit
    void Quit();
}

// Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Properties to store employee details
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method from IQuittable interface
    public void Quit()
    {
        // Example implementation: display a quit message
        Console.WriteLine($"{FirstName} {LastName} has quit.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an Employee object
        Employee emp = new Employee()
        {
            Id = 1,
            FirstName = "Mohamad",
            LastName = "Al Ismail"
        };

        // Use polymorphism: create an IQuittable reference to an Employee object
        IQuittable quittableEmployee = emp;

        // Call the Quit method via the IQuittable interface reference
        quittableEmployee.Quit();

        // Wait for user input before closing console window
        Console.ReadLine();
    }
}
