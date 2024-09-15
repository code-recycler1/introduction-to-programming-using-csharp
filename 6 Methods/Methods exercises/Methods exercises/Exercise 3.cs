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

            teamName = ReadName($"For which team would you like to print the scarf (\"{new string('*', teamNameLength)}\" = stop)? ", teamNameLength);

            while (teamName != new string('*', teamNameLength))
            {
                PrintTitle(teamName);

                symbol1 = ReadSymbol("Choose symbol 1: ", "");

                symbol2 = ReadSymbol("Choose symbol 2: ", symbol1);

                scarfLength = ReadNumber("How long", minimumLength);

                scarfWidth = ReadNumber("How wide", scarfLength / 2);

                stripeSymbol1 = DetermineStripe(symbol1, scarfWidth);
                stripeSymbol2 = DetermineStripe(symbol2, scarfWidth);

                PrintScarf(stripeSymbol1, stripeSymbol2, scarfLength);

                teamName = ReadName($"For which team would you like to print the scarf (\"{new string('*', teamNameLength)}\" = stop)? ", teamNameLength);
            }

            // Wait for user to press Enter
            PressEnter();
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 3";
        }

        private static string ReadName(string question, int length)
        {
            string teamName;

            do
            {
                Console.Write(question);
                teamName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(teamName) || teamName.Length < length);

            return teamName;
        }

        private static void PressEnter()
        {
            Console.WriteLine();
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }

        private static void PrintTitle(string name)
        {
            string title = "Supporter's Scarf for";

            Console.WriteLine($"\n{title} {name}");
            Console.WriteLine(new string('*', title.Length + name.Length + 1));
        }

        private static string ReadSymbol(string question, string comparingSymbol)
        {
            string input;

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

            do
            {
                Console.Write($"{questionPart} should the scarf be (min. {minimumValue})? ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out value) || value < minimumValue);

            return value;
        }
        
        private static string DetermineStripe(string symbol, int width)
        {
            return new string(Convert.ToChar(symbol), width);
        }

        private static void PrintScarf(string stripe1, string stripe2, int length)
        {
            string scarf = "\n";

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

            Console.WriteLine($"{scarf}");
        }
        #endregion
    }
}
