using System;

namespace BasicMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking an input from the user and multiplying it by 50
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int multipliedResult = number * 50;
            Console.WriteLine($"Result after multiplying by 50: {multipliedResult}");

            // Taking an input from the user and adding 25 to it
            Console.Write("Enter another number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            int addedResult = number + 25;
            Console.WriteLine($"Result after adding 25: {addedResult}");

            // Taking an input from the user and dividing it by 12.5
            Console.Write("Enter a number to divide by 12.5: ");
            input = Console.ReadLine();
            double doubleNumber = double.Parse(input);
            double dividedResult = doubleNumber / 12.5;
            Console.WriteLine($"Result after dividing by 12.5: {dividedResult}");

            // Taking an input from the user and checking if it is greater than 50
            Console.Write("Enter a number to check if it is greater than 50: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            bool isGreaterThan50 = number > 50;
            Console.WriteLine($"Is the number greater than 50? {isGreaterThan50}");

            // Taking an input from the user and printing the remainder after dividing by 7
            Console.Write("Enter a number to find the remainder after dividing by 7: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            int remainder = number % 7;
            Console.WriteLine($"Remainder after dividing by 7: {remainder}");

            // Pausing the console before closing
            Console.ReadLine();
        }
    }
}
