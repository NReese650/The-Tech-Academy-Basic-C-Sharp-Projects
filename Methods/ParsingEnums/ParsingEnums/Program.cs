using System;

namespace ConsoleApp
{
    class Program
    {
        // Enum for the days of the week
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert the user input to the enum type using Enum.TryParse method
                if (Enum.TryParse(userInput, true, out DaysOfWeek currentDay))
                {
                    // The user input was successfully converted to the enum type
                    Console.WriteLine("The current day of the week is: " + currentDay);
                }
                else
                {
                    // The user input did not match any of the enum values
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                // Catch any exception that occurs during the execution
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
