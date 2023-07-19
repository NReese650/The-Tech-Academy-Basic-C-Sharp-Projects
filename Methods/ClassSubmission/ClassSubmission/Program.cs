using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Submission Assignment");

            //Istantiate the divide class
            Divide output = new Divide();

            // Prompt the user for input
            Console.Write("Enter a number: ");

            // Read the input from the user
            string input = Console.ReadLine();

            // Parse the input string to an integer
            if (int.TryParse(input, out int number))
            {
                // Call the DivideByTwo method on the entered number
                output.DivideByTwo(number, out int result);

                // Call the static MultiplyByTwo method on the entered number
                StaticMultiplier.MultiplyByTwo(number, out int staticResult);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Wait for user input before exiting the program
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}