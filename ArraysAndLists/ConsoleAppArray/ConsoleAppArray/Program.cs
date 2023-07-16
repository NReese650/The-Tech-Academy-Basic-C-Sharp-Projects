using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] stringArray = { "Apple", "Banana", "Orange", "Grapes" };

        // Ask the user to select an index of the array
        Console.WriteLine("Select an index of the string array (0-3): ");
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index is valid
        if (stringIndex >= 0 && stringIndex < stringArray.Length)
        {
            // Display the string at the selected index
            Console.WriteLine("Selected string: " + stringArray[stringIndex]);
        }
        else
        {
            // Display an error message for invalid index
            Console.WriteLine("Invalid index selected.");
        }

        // Create a one-dimensional array of integers
        int[] intArray = { 10, 20, 30, 40 };

        // Ask the user to select an index of the array
        Console.WriteLine("Select an index of the integer array (0-3): ");
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index is valid
        if (intIndex >= 0 && intIndex < intArray.Length)
        {
            // Display the integer at the selected index
            Console.WriteLine("Selected integer: " + intArray[intIndex]);
        }
        else
        {
            // Display an error message for invalid index
            Console.WriteLine("Invalid index selected.");
        }

        // Create a list of strings
        List<string> stringList = new List<string> { "Cat", "Dog", "Elephant", "Lion" };

        // Ask the user to select an index of the list
        Console.WriteLine("Select an index of the string list (0-3): ");
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the selected index is valid
        if (listIndex >= 0 && listIndex < stringList.Count)
        {
            // Display the content at the selected index
            Console.WriteLine("Selected string from list: " + stringList[listIndex]);
        }
        else
        {
            // Display an error message for invalid index
            Console.WriteLine("Invalid index selected.");
        }
    }
}
