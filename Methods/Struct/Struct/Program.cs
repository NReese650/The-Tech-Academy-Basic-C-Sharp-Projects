using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type Number
            Number myNumber = new Number();

            // Assign an amount to the Amount property of the Number object
            myNumber.Amount = 123.45M;

            // Print the amount to the console
            Console.WriteLine("Amount: " + myNumber.Amount);

            Console.ReadLine();
        }
    }
}
