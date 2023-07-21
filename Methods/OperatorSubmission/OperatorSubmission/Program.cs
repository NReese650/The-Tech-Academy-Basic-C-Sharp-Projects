using System;

namespace OperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee emp1 = new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Employee emp2 = new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith"
            };

            // Compare the two Employee objects using the overloaded "==" and "!=" operators
            bool areEqual = emp1 == emp2;
            bool areNotEqual = emp1 != emp2;

            // Display the results
            Console.WriteLine("Are the employees equal? " + areEqual);
            Console.WriteLine("Are the employees not equal? " + areNotEqual);

            Console.ReadLine();
        }
    }
}
