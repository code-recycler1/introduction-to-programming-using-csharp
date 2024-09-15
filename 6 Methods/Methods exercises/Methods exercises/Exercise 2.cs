using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercises
{
    internal class Exercise_2
    {
        static void Main(string[] args)
        {
            // Set screen colors
            AdjustScreenColors();

            // Declare variables
            string lastname, firstname, suggestion;
            int choice;

            // Print the title of the program
            PrintTitle();

            // Prompt user for last name
            lastname = ReadName("\tWhat's your last name: ");
            // Prompt user for first name
            firstname = ReadName("\tWhat's your first name: ");

            // Prompt user for their hobby choice
            choice = ReadChoice($"\n\t{firstname.ToLower()} {lastname.ToUpper()}, what hobby do you practice? ");

            // Loop until the user enters 8 (None)
            while (choice != 8)
            {
                // Determine the suggestion based on the hobby choice
                suggestion = DetermineSuggestion(choice);

                // Print the suggestion
                PrintSuggestion(suggestion);

                // Wait for user to press Enter before asking for another suggestion
                PressEnter("\tPress enter to ask for another suggestion...");

                // Prompt user for an additional hobby choice
                choice = ReadChoice($"\n\t{firstname.ToLower()} {lastname.ToUpper()}, what extra hobby do you practice? ");
            }

            // Wait for user to press Enter before closing
            PressEnter("\tPress enter to continue...");
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            // Set the background color to white and text color to dark blue
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            // Set the console title to "Exercise 2"
            Console.Title = $"Exercise 2";
        }

        private static void PrintTitle()
        {
            string title = "Request general information";

            // Print the title of the program
            Console.WriteLine($"\t{title}");
            // Print a line of asterisks below the title
            Console.WriteLine($"\t{new string('*', title.Length)}");
        }

        private static string ReadName(string question)
        {
            string name;

            // Prompt the user for a name until a valid input is received
            do
            {
                Console.Write(question);
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));

            return name;
        }

        private static int ReadChoice(string question)
        {
            string input, hobbySummary = "\n\t1. Handicrafts (knitting, crocheting, ...)" +
                                         "\n\t2. Making clothing" +
                                         "\n\t3. Decorating the interior" +
                                         "\n\t4. Playing football" +
                                         "\n\t5. Riding a bike" +
                                         "\n\t6. Photography" +
                                         "\n\t7. Running" +
                                         "\n\t8. None";
            int choice;

            // Prompt the user for a hobby choice until a valid input is received
            do
            {
                Console.Clear();
                Console.WriteLine(hobbySummary);

                Console.Write(question);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out choice) || choice < 1 || choice > 8);

            return choice;
        }

        private static string DetermineSuggestion(int choice)
        {
            string suggestion = "We suggest as magazine: \"";

            // Determine the suggestion based on the hobby choice
            switch (choice)
            {
                case 1:
                    suggestion += "Anna";  // Handicrafts
                    break;
                case 2:
                    suggestion += "Snippie";  // Making clothing
                    break;
                case 3:
                    suggestion += "Living etc.";  // Decorating the interior
                    break;
                case 4:
                    suggestion += "Football International";  // Playing football
                    break;
                case 5:
                    suggestion += "Hiking & Cycling";  // Riding a bike
                    break;
                case 6:
                    suggestion += "Zoom EN";  // Photography
                    break;
                case 7:
                    suggestion += "Runners";  // Running
                    break;
            }
            suggestion += "\"";

            return suggestion;
        }

        private static void PrintSuggestion(string suggestion)
        {
            // Set the text color to blue and background color to yellow
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            // Print the suggestion with padding
            Console.WriteLine("\n{0}\n{0}\n{1}{2}\n{0}\n{0}\n", new string(' ', suggestion.Length + 8), new string(' ', 8), suggestion);
            // Reset the text color to dark blue and background color to white
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void PressEnter(string message)
        {
            // Prompt the user to press Enter to continue
            Console.WriteLine();
            Console.Write(message);
            Console.ReadLine();
        }
        #endregion
    }
}
