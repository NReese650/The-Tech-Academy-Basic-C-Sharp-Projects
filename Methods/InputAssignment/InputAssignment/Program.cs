using System;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.WriteLine("Please enter a number:");
            string inputNumber = Console.ReadLine();

            // Log the number to a text file
            LogNumberToFile(inputNumber);

            // Print the text file back to the user
            PrintLogFile();

            // Wait for user input to exit the program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void LogNumberToFile(string number)
        {
            // Specify the file path
            string filePath = "number_log.txt";

            // Append the number to the file (if the file doesn't exist, it will be created)
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(number);
            }
        }

        static void PrintLogFile()
        {
            // Specify the file path
            string filePath = "number_log.txt";

            // Read the contents of the file and print it to the console
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nContents of the text file:");
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("\nThe text file is empty or does not exist.");
            }
        }
    }
}
