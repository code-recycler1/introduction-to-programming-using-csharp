using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 10";

            string lastName, firstName, hobby, magazine;

            // Get user input
            Console.Write("\tWhat's your last name: ");
            lastName = Console.ReadLine().ToUpper();

            Console.Write("\tWhat's your first name: ");
            firstName = Console.ReadLine().ToLower();

            Console.WriteLine("\n\t1. Handicrafts (knitting, crocheting, ...)" +
                              "\n\t2. Making clothing" +
                              "\n\t3. Decorating the interior" +
                              "\n\t4. Soccer" +
                              "\n\t5. Riding a bike" +
                              "\n\t6. Photography" +
                              "\n\t7. Running");

            Console.Write($"\n\t{firstName} {lastName}, what hobby do you practice? ");
            hobby = Console.ReadLine();

            // Determine the magazine based on the hobby
            switch (hobby)
            {
                case "1":
                    magazine = "Anna";
                    break;
                case "2":
                    magazine = "Snippie";
                    break;
                case "3":
                    magazine = "Living etc.";
                    break;
                case "4":
                    magazine = "Football International";
                    break;
                case "5":
                    magazine = "Hiking & Biking";
                    break;
                case "6":
                    magazine = "Zoom EN";
                    break;
                case "7":
                    magazine = "Runners";
                    break;
                default:
                    magazine = "none";
                    break;
            }

            // Display the suggestion with extra blank lines and correct colors
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n\n\n\tWe suggest as magazine: \"" + magazine + "\".\n\n\n");

            // Reset console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();
        }
    }
}
