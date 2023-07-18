using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicOperations math = new BasicOperations();

            // Call the first method, passing in an integer
            int intResult = math.Operation(10);
            Console.WriteLine("Integer Result: " + intResult);

            // Call the second method, passing in a decimal
            int decimalResult = math.Operation(3.14m);
            Console.WriteLine("Decimal Result: " + decimalResult);

            // Call the third method, passing in a string
            int stringResult = math.Operation("20");
            Console.WriteLine("String Result: " + stringResult);

            Console.ReadLine();
        }
    }
}
