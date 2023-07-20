using System;


// Abstract class Person
abstract class Person
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Method to be implemented by derived classes
    public abstract void SayName();
}

// Derived class Employee inheriting from Person
class Employee : Person
{
    //SayName() method
    public override void SayName()
    {
        Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
    }
}
