using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercises_extra
{
    internal class Exercise_2
    {
        static void Main(string[] args)
        {
            // Set initial screen colors: white background with black text
            ScreenColors(ConsoleColor.Black, ConsoleColor.White);

            Console.Title = "Exercise 2";

            // Declare variables
            double height;
            int wrist;
            double weight;

            // Print the title and underline it
            Console.WriteLine("Ideal Weight");
            PrintLine(12, "-");

            // Prompt for height and wrist measurement
            Console.Write("Enter height in cm: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Enter wrist circumference in cm: ");
            wrist = int.Parse(Console.ReadLine());

            // Clear the screen for the result display
            ScreenColors(ConsoleColor.Blue, ConsoleColor.White);

            // Print result title and underline it
            Console.WriteLine("Result");
            PrintLine(6, "*");

            // Calculate and display ideal weight
            weight = IdealWeight(height, wrist);
            Console.WriteLine($"Your ideal weight is {weight:0.0} kg.");

            // Prompt to close the program
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        // Method to print a line of a specified number of characters
        private static void PrintLine(int count, string character)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }

        // Method to set console colors and clear the screen
        private static void ScreenColors(ConsoleColor foreground, ConsoleColor background)
        {
            Console.Clear(); // Clear the screen before changing colors
            Console.ForegroundColor = foreground;
            Console.BackgroundColor = background;
            Console.Clear(); // Clear the screen again to apply new background color
        }

        // Method to calculate the ideal weight
        private static double IdealWeight(double height, int wrist)
        {
            double weight;

            weight = (height - 100 + 4 * wrist) / 2;

            return weight;
        }
    }
}
