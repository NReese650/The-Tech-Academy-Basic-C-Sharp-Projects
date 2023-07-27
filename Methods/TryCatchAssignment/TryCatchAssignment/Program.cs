using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Prompt the user to enter their age
            Console.WriteLine("Please enter your age:");
            var age = Convert.ToInt32(Console.ReadLine());

            // Check if the age is valid (greater than 0)
            if (age <= 0)
            {
                // If the age is 0 or negative, throw an exception
                throw new ArgumentException("Age cannot be zero or a negative number.");
            }

            // Calculate and display the year the user was born
            var birthYear = DateTime.Now.Year - age;
            Console.WriteLine("You were born in the year {}.", birthYear);
        }
        catch (ArgumentException ex)
        {
            // If an ArgumentException was thrown (due to invalid age), print its message
            Console.WriteLine("Error: {}", ex.Message);
        }
        catch (Exception ex)
        {
            // If any other exception occurred, print a general error message
            Console.WriteLine("An error occurred: {}", ex.Message);
        }
    }
}
