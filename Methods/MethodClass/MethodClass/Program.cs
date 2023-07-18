using System;

namespace Void
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Call the method in the class, passing in two numbers
            math.Operation(5, 10);

            // Call the method in the class, specifying the parameters by name
            math.Operation(number1: 7, number2: 20);

            Console.ReadLine();
        }
    }
}
