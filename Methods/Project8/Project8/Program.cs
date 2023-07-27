﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Project8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Please tell me your name");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money will you be playing with today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {0}. Would you like to play a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
         
        }

    }

}
