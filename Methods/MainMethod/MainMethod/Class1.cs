using System;

namespace MathOperations
{
    public class BasicOperations
    {
        // Method to perform math operations on an integer
        public int Operation(int number)
        {
            // Perform some math operation on the integer
            int result = number + 10;
            return result;
        }

        // Method to perform math operations on a decimal
        public int Operation(decimal number)
        {
            // Perform a different math operation on the decimal
            int result = (int)(number * 2);
            return result;
        }

        // Method to perform math operations on a string (if it represents an integer)
        public int Operation(string numberString)
        {
            int number;
            if (int.TryParse(numberString, out number))
            {
                // Perform a different math operation on the parsed integer
                int result = number - 5;
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. The provided string is not a valid integer.");
                return 0;
            }
        }
    }
}
