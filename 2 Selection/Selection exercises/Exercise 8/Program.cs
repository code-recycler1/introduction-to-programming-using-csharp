using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set initial console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 8";

            // Declare variables
            string motto, backgroundcolor, foregroundcolor;

            // Get motto from user
            Console.Write("What is your motto? ");
            motto = Console.ReadLine();

            // Display background color options
            Console.WriteLine("\nB. Blue" +
                              "\nR. Red" +
                              "\nY. Yellow");

            // Get background color choice from user
            Console.Write("\nWhat background color would you like to use? ");
            backgroundcolor = Console.ReadLine().ToLower();

            // Display text color options
            Console.WriteLine("\nD. Dark Green" +
                              "\nW. White" +
                              "\nC. Cyan");

            // Get text color choice from user
            Console.Write("\nWhat text color would you like to use? ");
            foregroundcolor = Console.ReadLine().ToUpper();

            // Apply background color based on user input
            switch (backgroundcolor)
            {
                case "b":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "r":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "y":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.White; // Default background color
                    break;
            }

            // Apply foreground color based on user input
            switch (foregroundcolor)
            {
                case "D":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "W":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "C":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkBlue; // Default text color
                    break;
            }

            // Clear the screen to apply the new colors
            Console.Clear();

            // Display the motto in uppercase
            Console.WriteLine($"My motto is \"{motto.ToUpper()}\"!");

            // Wait for user input before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
