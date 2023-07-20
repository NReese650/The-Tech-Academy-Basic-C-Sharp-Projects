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

            // Creating an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = new Employee();
            // Setting employee details
            ((Employee)quittableEmployee).FirstName = "Sample";
            ((Employee)quittableEmployee).LastName = "Student";

            // Calling the Quit() method on the quittableEmployee object
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
