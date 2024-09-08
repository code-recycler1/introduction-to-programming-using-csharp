using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = $"Exercise 1 - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            int number1, number2;
            string input, message;

            // Ask the user for the first number
            do
            {
                Console.Write("Give a first number: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out number1));

            // Ask the user for the second number
            do
            {
                Console.Write("Give a second number: ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out number2));

            // Use the conditional (ternary) operator to check which number is larger
            message = (number1 > number2)
                        ? $"{number1} - {number2} = {number1 - number2}"  // If number1 is larger
                        : $"{number2} - {number1} = {number2 - number1}"; // If number2 is larger or they are equal

            // Display the result
            Console.WriteLine($"\n{message}");

            // Wait for the user to press enter before exiting
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
