using System;
using System.Text;

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenating three strings
            string string1 = "Hello";
            string string2 = "world";
            string string3 = "!";

            string concatenatedString = string1 + " " + string2 + string3;

            Console.WriteLine("Concatenated String: " + concatenatedString);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.WriteLine();

            // Converting a string to uppercase
            string lowercaseString = "hello world";
            string uppercaseString = lowercaseString.ToUpper();

            Console.WriteLine("Uppercase String: " + uppercaseString);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.WriteLine();

            // Building a paragraph using StringBuilder
            StringBuilder paragraphBuilder = new StringBuilder();

            // Append the first sentence
            paragraphBuilder.Append("This is the first sentence. ");
            Console.WriteLine(paragraphBuilder.ToString());

            // Wait for the user to press a key
            Console.ReadLine();

            // Append the second sentence
            paragraphBuilder.Append("This is the second sentence. ");
            Console.WriteLine(paragraphBuilder.ToString());

            // Wait for the user to press a key
            Console.ReadLine();

            // Append the third sentence
            paragraphBuilder.Append("This is the third sentence.");
            Console.WriteLine(paragraphBuilder.ToString());

            // Wait for the user to press a key
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
    
}
