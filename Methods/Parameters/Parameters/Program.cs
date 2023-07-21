using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string" and assign a list of strings to Things
            Employee<string> employeeString = new Employee<string>();
            employeeString.Things = new List<string> { "Apple", "Banana", "Orange" };

            // Instantiate an Employee object with type "int" and assign a list of integers to Things
            Employee<int> employeeInt = new Employee<int>();
            employeeInt.Things = new List<int> { 1, 2, 3, 4, 5 };

            // Loop to print all the Things of the Employee objects to the Console
            Console.WriteLine("Things in employeeString:");
            foreach (var item in employeeString.Things)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nThings in employeeInt:");
            foreach (var item in employeeInt.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
