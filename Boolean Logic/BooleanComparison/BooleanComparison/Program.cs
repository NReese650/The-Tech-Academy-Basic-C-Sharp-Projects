using System;

namespace WordGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Word guessing game
            Console.WriteLine("Welcome to the Word Guessing Game!");

            // Set the secret word
            string secretWord = "wall";

            // Initialize the user's guess
            string guess = "";

            // Continue the game until the correct word is guessed
            while (guess.ToLower() != secretWord)
            {
                // Prompt the user for a guess
                Console.Write("Humpty Dumpty sat on a ");
                guess = Console.ReadLine();

                if (guess.ToLower() == secretWord)
                {
                    Console.WriteLine("Congratulations! You guessed it right!");
                }
                else
                {
                    Console.WriteLine("Wrong guess. Try again!");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Thank you for playing the Word Guessing Game!");

            {

                ///////////////////////////////////////////////////////////////////////////

            // Boolean comparison using a do while statement
            Console.WriteLine("Boolean comparison using a do while statement:");

            string userChoice;

            do
            {
                // Prompt the user for a choice
                Console.Write("Enter your choice (1-3): ");
                userChoice = Console.ReadLine();

                // Validate the choice
                if (userChoice == "1")
                {
                    Console.WriteLine("You chose the path to Grandma's house!");
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("You chose to pick flowers in the meadow!");
                }
                else if (userChoice == "3")
                {
                    Console.WriteLine("You chose to go back home!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);

            } while (userChoice != "1" && userChoice != "2" && userChoice != "3");

            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            }
        }


    }
}
