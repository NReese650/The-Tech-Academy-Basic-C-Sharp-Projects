using System;

namespace AbstractClass
{
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
    class Employee : Person, IQuittable
    {
        //SayName() method
        public override void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }

        // Implementation of the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }
    }
}
