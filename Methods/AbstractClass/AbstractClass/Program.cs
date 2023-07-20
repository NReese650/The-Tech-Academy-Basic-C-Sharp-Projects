using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating an Employee object
            Employee employee = new Employee();

            // Setting the properties
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Calling the SayName() method on the employee object
            employee.SayName();

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
