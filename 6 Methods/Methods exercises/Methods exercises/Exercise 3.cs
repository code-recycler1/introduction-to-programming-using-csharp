using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercises
{
    internal class Exercise_3
    {
        static void Main(string[] args)
        {
            // Set screen colors
            AdjustScreenColors();

            // Declare variables
            string symbol1, symbol2, stripeSymbol1, stripeSymbol2, teamName;
            int scarfLength, scarfWidth, minimumLength = 4, teamNameLength = 5;

            // Prompt user for the team name
            teamName = ReadName($"For which team would you like to print the scarf (\"{new string('*', teamNameLength)}\" = stop)? ", teamNameLength);

            // Loop until the user enters the stop condition
            while (teamName != new string('*', teamNameLength))
            {
                // Print the title with the team name
                PrintTitle(teamName);

                // Prompt user for the first symbol
                symbol1 = ReadSymbol("Choose symbol 1: ", "");

                // Prompt user for the second symbol, ensuring it's different from the first
                symbol2 = ReadSymbol("Choose symbol 2: ", symbol1);

                // Prompt user for the scarf length
                scarfLength = ReadNumber("How long", minimumLength);

                // Prompt user for the scarf width
                scarfWidth = ReadNumber("How wide", scarfLength / 2);

                // Determine the stripe pattern for the first symbol
                stripeSymbol1 = DetermineStripe(symbol1, scarfWidth);
                // Determine the stripe pattern for the second symbol
                stripeSymbol2 = DetermineStripe(symbol2, scarfWidth);

                // Print the scarf with the determined stripe patterns
                PrintScarf(stripeSymbol1, stripeSymbol2, scarfLength);

                // Prompt user for the next team name
                teamName = ReadName($"For which team would you like to print the scarf (\"{new string('*', teamNameLength)}\" = stop)? ", teamNameLength);
            }

            // Wait for user to press Enter before closing
            PressEnter();
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            // Set the background color to white and text color to dark blue
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            // Set the console title to "Exercise 3"
            Console.Title = "Exercise 3";
        }

        private static string ReadName(string question, int length)
        {
            string teamName;

            // Prompt the user for the team name until a valid input is received
            do
            {
                Console.Write(question);
                teamName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(teamName) || teamName.Length < length);

            return teamName;
        }

        private static void PressEnter()
        {
            // Prompt the user to press Enter to continue
            Console.WriteLine();
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        private static void PrintTitle(string name)
        {
            string title = "Supporter's Scarf for";

            // Print the title with the team name
            Console.WriteLine($"\n{title} {name}");
            // Print a line of asterisks below the title
            Console.WriteLine(new string('*', title.Length + name.Length + 1));
        }

        private static string ReadSymbol(string question, string comparingSymbol)
        {
            string input;

            // Prompt the user for a symbol until a valid input is received and it's different from the comparing symbol
            do
            {
                Console.Write(question);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input) || input == comparingSymbol);

            return input;
        }

        private static int ReadNumber(string questionPart, int minimumValue)
        {
            string input;
            int value;

            // Prompt the user for a number until a valid input is received and it's greater than or equal to the minimum value
            do
            {
                Console.Write($"{questionPart} should the scarf be (min. {minimumValue})? ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out value) || value < minimumValue);

            return value;
        }
        
        private static string DetermineStripe(string symbol, int width)
        {
            // Create a string of the given symbol repeated to the specified width
            return new string(Convert.ToChar(symbol), width);
        }

        private static void PrintScarf(string stripe1, string stripe2, int length)
        {
            string scarf = "\n";

            // Loop to create the scarf pattern
            for (int i = 1; i <= length; i++)
            {
                if (i % 2 == 0)
                {
                    scarf += stripe2;
                }
                else
                {
                    scarf += stripe1;
                }

                scarf += "\n";
            }

            // Print the scarf
            Console.WriteLine($"{scarf}");
        }
        #endregion
    }
}
