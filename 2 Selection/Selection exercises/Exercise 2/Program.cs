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
            // Set console background and text colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 2"; // Set the console title

            // Declare variables
            int number1, number2;
            string message;

            // Read input from the user
            Console.Write("Give a first round number: ");
            number1 = int.Parse(Console.ReadLine()); // Parse the input as an integer

            Console.Write("Give a second round number: ");
            number2 = int.Parse(Console.ReadLine()); // Parse the input as an integer

            // Check if number2 is zero to avoid division by zero
            message = (number2 == 0) ?
                $"{number1} cannot be divided by 0!" :
                $"{number1} / {number2} = {number1 / number2}";

            // Output the result
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine(); // Wait for the user to press enter before exiting

        }
    }
}
