using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Exercise 2 - {DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            string title = "Request general information";
            string lastname, firstname, input = "", magazine, message;
            string hobbySummary = "\n\t1. Handicrafts (knitting, crocheting, ...)" +
                                  "\n\t2. Making clothing" +
                                  "\n\t3. Decorating the interior" +
                                  "\n\t4. Playing football" +
                                  "\n\t5. Riding a bike" +
                                  "\n\t6. Photography" +
                                  "\n\t7. Running" +
                                  "\n\t8. None";  // Last option allows the user to exit the program

            int hobby;

            // Display the title and underline it with stars (same length as title)
            Console.WriteLine($"\t{title}");
            Console.WriteLine($"\t{new string('*', title.Length)}");

            // Ask the user for their last name, ensuring it's valid (non-empty and non-whitespace)
            do
            {
                Console.Write("\tWhat's your last name: ");
                lastname = Console.ReadLine().ToUpper();  // Store the last name in uppercase
            } while (string.IsNullOrWhiteSpace(lastname));

            // Ask the user for their first name, ensuring it's valid
            do
            {
                Console.Write("\tWhat's your first name: ");
                firstname = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(firstname));

            while (input.ToLower() != "none")
            {
                // Loop until a valid hobby option (between 1 and 8) is entered
                do
                {
                    Console.Clear();  // Clear the screen before showing the hobby options
                    Console.WriteLine(hobbySummary);  // Display the hobby list

                    // Ask the user to pick a hobby by entering the corresponding number
                    Console.Write($"\n\t{firstname} {lastname}, what hobby do you practice? ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out hobby) || hobby < 1 || hobby > 8);  // Ensure valid input

                // Determine the corresponding magazine based on the hobby choice
                switch (hobby)
                {
                    case 1:
                        magazine = "Anna";  // Handicrafts
                        break;
                    case 2:
                        magazine = "Snippie";  // Making clothing
                        break;
                    case 3:
                        magazine = "Living etc.";  // Decorating the interior
                        break;
                    case 4:
                        magazine = "Football International";  // Playing football
                        break;
                    case 5:
                        magazine = "Hiking & Cycling";  // Riding a bike
                        break;
                    case 6:
                        magazine = "Zoom EN";  // Photography
                        break;
                    case 7:
                        magazine = "Runners";  // Running
                        break;
                    default:
                        magazine = "";  // No hobby selected, program will end
                        break;
                }

                // Display the appropriate message based on the hobby choice
                if (magazine != "")
                {
                    message = $"We suggest as magazine: \"{magazine}\".";

                    // Change the background and foreground colors for the suggestion message
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    // Display the suggestion with some padding for aesthetic
                    Console.WriteLine();
                    Console.WriteLine($"\t{new string(' ', message.Length)}\n\t{new string(' ', message.Length)}");
                    Console.WriteLine($"\t{message}");
                    Console.WriteLine($"\t{new string(' ', message.Length)}\n\t{new string(' ', message.Length)}");

                    // Reset the background to white
                    Console.BackgroundColor = ConsoleColor.White;
                }

                // Ask the user to press enter to ask for another suggestion
                Console.WriteLine("\n\tPress enter to ask for another suggestion...");
                Console.ReadLine();
            }

            // Ask the user to press enter to close the program
            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();
        }
    }
}
