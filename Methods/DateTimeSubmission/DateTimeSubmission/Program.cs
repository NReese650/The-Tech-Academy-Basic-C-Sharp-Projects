using System;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Print the current date and time to the console
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current date and time: " + currentDateTime);

            // Step 2: Ask the user for a number
            Console.WriteLine("\nPlease enter a number:");

            // Validate and read the user input
            if (int.TryParse(Console.ReadLine(), out int hoursToAdd))
            {
                // Step 3: Calculate the exact time it will be in X hours and print it to the console
                DateTime futureDateTime = currentDateTime.AddHours(hoursToAdd);
                Console.WriteLine("Exact time in " + hoursToAdd + " hours: " + futureDateTime);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Wait for user input to exit the program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
