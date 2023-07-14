using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.Write("Please enter the package weight: ");
            float weight = float.Parse(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                // Display an error message and end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            // Prompt the user for the package width
            Console.Write("Please enter the package width: ");
            float width = float.Parse(Console.ReadLine());

            // Prompt the user for the package height
            Console.Write("Please enter the package height: ");
            float height = float.Parse(Console.ReadLine());

            // Prompt the user for the package length
            Console.Write("Please enter the package length: ");
            float length = float.Parse(Console.ReadLine());

            // Calculate the total dimensions by adding width, height, and length
            float dimensionsTotal = width + height + length;

            // Check if the dimensions total is greater than 50
            if (dimensionsTotal > 50)
            {
                // Display an error message and end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            // Calculate the quote by multiplying the dimensions total by the weight and dividing the outcome by 100
            float quote = (dimensionsTotal * weight) / 100;

            // Display the quote to the user as a dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));

            // Display a thank you message
            Console.WriteLine("Thank you!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
