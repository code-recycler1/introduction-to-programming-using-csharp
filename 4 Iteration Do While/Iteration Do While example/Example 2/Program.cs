using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Example 2 {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";

            // Declare variables
            Random random = new Random();
            int randomNumber, minValue = 1, maxValue = 10, numberOfAttempts, desiredNumber;
            string drawnNumbersOverview, input;

            // Initialization
            drawnNumbersOverview = string.Empty;

            // Read desired number
            do
            {
                Console.Write($"Choose a number between {minValue} and {maxValue}: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out desiredNumber) || desiredNumber < minValue || desiredNumber > maxValue);

            // Retrieve random numbers
            numberOfAttempts = 0;

            do
            {
                numberOfAttempts++;

                randomNumber = random.Next(minValue, maxValue + 1);

                drawnNumbersOverview += $"{new string(' ', 30)}{new string('-', 5)}> {randomNumber}\n";
            }
            while (randomNumber != desiredNumber);

            // Display the result
            Console.WriteLine($"These are the random numbers the computer has drawn for you,\nbefore he drawed your desired number!\n");
            Console.WriteLine($"Number of attempts: {numberOfAttempts}\n");
            Console.WriteLine(drawnNumbersOverview);

            // Wait for user to press Enter
            Console.WriteLine();
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
