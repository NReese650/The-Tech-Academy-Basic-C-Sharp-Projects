using System;

namespace TwoNumbers
{
    public class MathOperations
    {
        // Method to perform math operations on two integers
        public int Operation(int number1, int number2 = 0)
        {
            // Perform some math operation on the numbers
            int result = number1 + number2;
            return result;
        }
    }

    public static class StaticDivider
    {
        public static void DivideByTwo(int data, out int result)
        {
            result = data / 2;
        }
    }
}
