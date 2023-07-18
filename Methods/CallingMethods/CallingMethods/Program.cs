using System;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number to perform math operations on
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of the MathMethods class
            MathMethods math = new MathMethods();

            // Call each method, passing the user input, and display the returned result
            int result1 = math.Add(userInput);
            Console.WriteLine("Addition result: " + result1);

            int result2 = math.Subtract(userInput);
            Console.WriteLine("Subtraction result: " + result2);

            int result3 = math.Multiply(userInput);
            Console.WriteLine("Multiplication result: " + result3);

            Console.ReadLine();
        }
    }
}
