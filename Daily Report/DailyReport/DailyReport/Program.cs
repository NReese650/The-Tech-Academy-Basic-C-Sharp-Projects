using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");  // Printing the academy name
            Console.WriteLine("Student Daily Report");  // Printing the report title
            Console.WriteLine();  // Adding a blank line for readability

            // Asking and saving data from the student
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine();

            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine();

            Console.Write("What page number? ");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.Write("Do you need help with anything? Please answer \"true\" or \"false\": ");
            bool needsHelp = bool.Parse(Console.ReadLine());

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string feedback = Console.ReadLine();

            Console.Write("How many hours did you study today? ");
            double studyHours = double.Parse(Console.ReadLine());

            Console.WriteLine();  // Adding a blank line for readability

            // Printing the final message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Pausing the console before closing
            Console.ReadLine();
        }
    }
}
