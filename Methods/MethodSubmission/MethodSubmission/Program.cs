using System;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Ask the user for the first number
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user for the second number
            Console.Write("Enter the second number (optional): ");
            string number2Input = Console.ReadLine();
            int number2 = 0;

            // Check if the second number is provided
            if (string.IsNullOrWhiteSpace(number2Input))
            {
                // If no input provided, call the method with one parameter
                int result = math.Operation(number1);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                // If input provided, parse the number
                bool parsed = int.TryParse(number2Input, out number2);
                if (!parsed)
                {
                    Console.WriteLine("Invalid input. The provided value is not a valid integer.");
                    return;
                }

                // Call the method with both parameters
                int result = math.Operation(number1, number2);
                Console.WriteLine("Result: " + result);
            }

            

            Console.ReadLine();
        }
    }
}
