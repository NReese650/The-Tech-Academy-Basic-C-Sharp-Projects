using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123
            };

            // Call the superclass method SayName() on the Employee object
            employee.SayName();

            Console.ReadKey();
        }
    }
}
