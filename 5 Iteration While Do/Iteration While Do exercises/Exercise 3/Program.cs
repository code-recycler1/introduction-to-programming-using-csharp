using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Exercise 3 - {DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";

            // Declare variables for scarf dimensions, symbols, and user input
            int length, width;
            string input, symbol1, symbol2;
            string teamQuestion = "For which team would you like to print the scarf (***** = stop)? ";

            // Loop to prompt for team names, stopping when the user enters "*****"
            do
            {
                // Ask the user for the team name and ensure it's at least 5 characters long
                Console.Write(teamQuestion);
                input = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(input) || input.Length < 5);

            // Continue while the user does not choose to stop by entering "*****"
            while (input != "*****")
            {
                // Display the title of the scarf creation for the given team
                string title = $"Supporter's Scarf for {input}";
                Console.WriteLine($"\n{title}");
                Console.WriteLine(new string('*', title.Length));

                // Ask for the first symbol (must be a single character)
                do
                {
                    Console.Write("Choose symbol 1: ");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input) || input.Length > 1);

                symbol1 = input;  // Store symbol 1

                // Ask for the second symbol (must be a single character)
                do
                {
                    Console.Write("Choose symbol 2: ");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input) || input.Length > 1 || input == symbol1);

                symbol2 = input;  // Store symbol 2

                // Ask for the length of the scarf (minimum of 4 knitting needles)
                do
                {
                    Console.Write("How long should the scarf be (min. 4)? ");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out length) || length < 4);

                // Ask for the width of the scarf (minimum of half the length and at least 3 stitches wide)
                do
                {
                    Console.Write($"How wide should the scarf be (min. {length / 2})? ");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out width) || width < (length / 2) || width < 3);

                Console.WriteLine();

                // Generate the scarf pattern based on the entered length and width
                for (int i = length; i > 0; i--)
                {
                    for (int j = width; j > 0; j--)
                    {
                        // Alternate symbols based on the row number (even or odd)
                        if (i % 2 == 0)
                        {
                            Console.Write(symbol1);
                        }
                        else
                        {
                            Console.Write(symbol2);
                        }
                    }
                    Console.WriteLine();  // Move to the next line after printing each row
                }

                // Prompt again for another team or stop by entering "*****"
                do
                {
                    Console.Write($"\n{teamQuestion}");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input) || input.Length < 5);
            }

            // Once the user enters "*****", end the program with a prompt to press enter
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();

        }
    }
}
