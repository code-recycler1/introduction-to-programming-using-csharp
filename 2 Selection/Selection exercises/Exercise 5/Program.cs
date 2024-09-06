using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 5";

            // Declare variables
            int score;
            string landingPlace;

            // Display the options
            Console.WriteLine("\t1. Arrow lands outside the board (0 points)");
            Console.WriteLine("\t2. Arrow lands in the outer ring (20 points)");
            Console.WriteLine("\t3. Arrow lands in the inner ring (50 points)");
            Console.WriteLine("\t4. Arrow lands in the bullseye (100 points)");

            // Read the input from the user
            Console.Write("\n\tWhere did your arrow land? (Enter 1, 2, 3, or 4): ");
            landingPlace = Console.ReadLine();

            // Use switch to determine the score
            switch (landingPlace)
            {
                case "1":
                    score = 0;
                    break;
                case "2":
                    score = 20;
                    break;
                case "3":
                    score = 50;
                    break;
                case "4":
                    score = 100;
                    break;
                default:
                    Console.WriteLine("\n\tInvalid input. Please enter a number between 1 and 4.");
                    Console.WriteLine("\n\tPress enter to exit...");
                    Console.ReadLine();
                    return;
            }

            // Display the result
            Console.WriteLine($"\n\tYou scored {score} points!");

            // Wait for the user to press Enter
            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();
        }
    }
}
