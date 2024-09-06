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
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 1";

            // Declare variables
            int sum = 0, quantity;

            // Ask the user for the quantity of numbers to sum
            Console.Write("How many numbers do you want to sum? ");
            quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"Give a number {i}: ");
                sum += int.Parse(Console.ReadLine());
            }

            // Display the result
            Console.WriteLine($"\nThe sum of the {quantity} numbers is {sum}.");

            // Wait for user input before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
