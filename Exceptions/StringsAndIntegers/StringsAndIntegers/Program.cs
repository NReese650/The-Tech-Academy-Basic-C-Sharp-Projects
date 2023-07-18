using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Ask the user for a number to divide each number in the list by
            Console.WriteLine("Enter a number to divide each number in the list by:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Loop to divide each integer in the list by the user-entered number and display the result
            foreach (int number in numbers)
            {
                int result = number / userNumber;
                Console.WriteLine(number + " divided by " + userNumber + " equals " + result);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Please don't divide by zero.");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.ReadLine();
        }

        // Message to indicate the program has emerged from the try/catch block and continued execution
        Console.WriteLine("Program execution continued after the try/catch block.");
        Console.ReadLine();
    }
}
