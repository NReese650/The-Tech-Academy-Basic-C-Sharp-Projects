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

            // Parse the second number if provided
            if (!string.IsNullOrWhiteSpace(number2Input))
                number2 = Convert.ToInt32(number2Input);

            // Call the method in the class, passing in the numbers
            int result = math.Operation(number1, number2);

            // Display the result
            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
    }
}
