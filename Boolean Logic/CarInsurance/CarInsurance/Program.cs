using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine();

            // Asking the applicant for their age
            Console.Write("What is your age? ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);

            // Asking the applicant if they have ever had a DUI
            Console.Write("Have you ever had a DUI? (true/false) ");
            string duiInput = Console.ReadLine();
            bool hasDui = bool.Parse(duiInput);

            // Asking the applicant for the number of speeding tickets
            Console.Write("How many speeding tickets do you have? ");
            string speedingTicketsInput = Console.ReadLine();
            int speedingTickets = int.Parse(speedingTicketsInput);

            Console.WriteLine();

            // Checking if the applicant qualifies for car insurance based on the given qualification rules
            bool isQualified = age > 15 && !hasDui && speedingTickets <= 3;

            // Printing the result of the qualification check
            Console.WriteLine("Qualified? " + isQualified);

            Console.ReadLine();
        }
    }
}
