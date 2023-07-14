using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine();

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            string hourlyRate1Input = Console.ReadLine();
            double hourlyRate1 = double.Parse(hourlyRate1Input);

            Console.Write("Hours worked per week: ");
            string hoursWorked1Input = Console.ReadLine();
            double hoursWorked1 = double.Parse(hoursWorked1Input);

            Console.WriteLine();

            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            string hourlyRate2Input = Console.ReadLine();
            double hourlyRate2 = double.Parse(hourlyRate2Input);

            Console.Write("Hours worked per week: ");
            string hoursWorked2Input = Console.ReadLine();
            double hoursWorked2 = double.Parse(hoursWorked2Input);

            Console.WriteLine();

            // Calculating annual salaries
            double annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
            double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;

            // Displaying annual salaries
            Console.WriteLine("Annual salary of Person 1: " + annualSalary1.ToString("C"));
            Console.WriteLine("Annual salary of Person 2: " + annualSalary2.ToString("C"));
            Console.WriteLine();

            // Comparing salaries and determining if Person 1 makes more money than Person 2
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + person1MakesMore);

            Console.ReadLine();
        }
    }
}
