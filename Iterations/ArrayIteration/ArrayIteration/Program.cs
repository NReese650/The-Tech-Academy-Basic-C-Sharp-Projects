using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create an array of strings representing fruits
        string[] fruits = { "Apple", "Banana", "Cherry", "Pecan" };

        // Ask the user to input some text related to fruits
        Console.WriteLine("Enter a word related to fruit desserts:");
        string userInput = Console.ReadLine();

        // Loop to append user's text to each fruit in the array
        for (int i = 0; i < fruits.Length; i++)
        {
            fruits[i] += userInput;
        }

        // Loop to print each fruit in the array
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
            Console.ReadLine();
        }

        // Loop using "<" operator
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Loop using \"<\" operator: " + i);
        }

        // Loop using "<=" operator

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Loop using \"<=\" operator: " + i);
        }



        // Create a list of strings representing states on the West Coast
        List<string> westCoastStates = new List<string> { "California", "Oregon", "Washington", "Oregon" };

        bool isFound = false;

        while (!isFound)
        {

            // Ask the user to input text to search for
            Console.WriteLine("Enter a state on the West Coast to search for:");
            string searchText = Console.ReadLine();

            // Loop to search for the text in the list

            for (int i = 0; i < westCoastStates.Count; i++)
            {
                if (westCoastStates[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Display the index of the matching state
                    Console.WriteLine("Match found at index: " + i);
                    isFound = true;
                    //break; // Stop the loop once a match is found. Removed for part 5
                }
            }

            if (!isFound)
            {
                // Display message if the input is not in the list
                Console.WriteLine("Input is not on the West Coast states list.");
            }

        }




        // Create a list of strings that has at least two identical strings (car brands)
        List<string> carBrands = new List<string> { "Ford", "Toyota", "BMW", "Tesla", "Toyota" };

        // Create a dictionary to keep track of seen car brands
        Dictionary<string, bool> seenBrands = new Dictionary<string, bool>();

        // Iterate through each car brand in the list using a foreach loop
        foreach (string brand in carBrands)
        {
            // Check if the car brand has already appeared in the list
            if (seenBrands.ContainsKey(brand))
            {
                // Display message for duplicate car brand
                Console.WriteLine(brand + " - this car brand is a duplicate");
            }
            else
            {
                // Add the car brand to the dictionary and mark it as seen
                seenBrands[brand] = true;

                // Display message for unique car brand
                Console.WriteLine(brand + " - this car brand is unique");
            }
        }




            // Prompt before the infinite loop
            Console.WriteLine("Are you ready for infinity? Press Enter to initiate the loop.");
        Console.ReadLine();
        // Fixing the infinite loop
        // Adding a break statement to exit the loop
        while (true)
        {
            Console.WriteLine("This is an infinite loop. Press any key to exit.");
            if (Console.KeyAvailable)
            {
                break; // Break the loop if any key is pressed
            }
        }
    }
}
