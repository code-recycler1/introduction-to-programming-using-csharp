using System;
using System.Collections.Generic;
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

            PrintTitle();

            lastname = ReadName("\tWhat's your last name: ");
            firstname = ReadName("\tWhat's your first name: ");

            choice = ReadChoice($"\n\t{firstname.ToLower()} {lastname.ToUpper()}, what hobby do you practice? ");

            while (choice != 8)
            {
                suggestion = DetermineSuggestion(choice);

                PrintSuggestion(suggestion);

                PressEnter("\tPress enter to ask for another suggestion...");

                choice = ReadChoice($"\n\t{firstname.ToLower()} {lastname.ToUpper()}, what extra hobby do you practice? ");
            }

            // Wait for user to press Enter
            PressEnter("\tPress enter to continue...");
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Exercise 2";
        }

        private static void PrintTitle()
        {
            string title = "Request general information";

            Console.WriteLine($"\t{title}");
            Console.WriteLine($"\t{new string('*', title.Length)}");
        }

        private static string ReadName(string question)
        {
            string name;

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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n{0}\n{0}\n{1}{2}\n{0}\n{0}\n", new string(' ', suggestion.Length + 8), new string(' ', 8), suggestion);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        private static void PressEnter(string message)
        {
            Console.WriteLine();
            Console.Write(message);
            Console.ReadLine();
        }
        #endregion
    }
}
