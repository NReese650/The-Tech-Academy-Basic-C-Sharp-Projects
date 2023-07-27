using System;

class Program
{
    

    static void Main(string[] args)
    {
        // Define Constant variable
        const int MaxAllowedAge = 120;

        // Ask for the user's name and age
        Console.WriteLine("Please enter your name:");
        var name = Console.ReadLine();
        Console.WriteLine("Please enter your age:");
        var age = Convert.ToInt32(Console.ReadLine());

        // Check if the entered age is valid.
        if (age > MaxAllowedAge)
        {
            Console.WriteLine("The entered age is not valid.");
            return;
        }

        // Create a new person using the provided name and age.
        var person = new Person(name, age);

        // Print the person's details
        Console.WriteLine("Hello {0}, you are {1} years old.", person.Name, person.Age);
        Console.ReadLine();
    }
}

public class Person
{
    // Define properties for the person's name and age.
    public string Name { get; set; }
    public int Age { get; set; }

    // First constructor
    public Person(string name) : this(name, 0)
    {
    }

    // Second constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}