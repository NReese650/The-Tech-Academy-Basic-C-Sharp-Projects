using System;


namespace MethodsAndObjects
{
    // Create a class called Person
    class Person
    {
        // Define properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Define a method that writes the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Create another class called Employee and inherit from the Person class
    class Employee : Person
    {
        // Add a property specific to the Employee class
        public int Id { get; set; }
    }
}
