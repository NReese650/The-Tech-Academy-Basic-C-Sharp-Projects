using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSubmission
{
    // Create an Employee class with properties Id, FirstName, and LastName
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Mike", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 6, FirstName = "Mary", LastName = "Taylor" },
                new Employee { Id = 7, FirstName = "David", LastName = "Lee" },
                new Employee { Id = 8, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 9, FirstName = "Joe", LastName = "Anderson" },
                new Employee { Id = 10, FirstName = "Emily", LastName = "Clark" }
            };

            // Using a foreach loop, create a new list of all employees with the first name “Joe”
            List<Employee> joesUsingForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                    joesUsingForeach.Add(employee);
            }

            // Using a lambda expression, create a new list of all employees with the first name “Joe”
            List<Employee> joesUsingLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Print the results to the console
            Console.WriteLine("Employees with first name 'Joe' using foreach loop:");
            foreach (var joe in joesUsingForeach)
            {
                Console.WriteLine(joe.Id + ", " + joe.FirstName + ", " + joe.LastName);
            }

            Console.WriteLine("\nEmployees with first name 'Joe' using lambda expression:");
            foreach (var joe in joesUsingLambda)
            {
                Console.WriteLine(joe.Id + ", " + joe.FirstName + ", " + joe.LastName);
            }

            Console.WriteLine("\nEmployees with Id greater than 5 using lambda expression:");
            foreach (var employee in employeesWithIdGreaterThan5)
            {
                Console.WriteLine(employee.Id + ", " + employee.FirstName + ", " + employee.LastName);
            }

            Console.ReadLine();
        }
    }
}
