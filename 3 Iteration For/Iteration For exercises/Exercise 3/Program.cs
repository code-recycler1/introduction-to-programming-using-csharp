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
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 3";

            // Declare variables
            int positiveNumber;
            string message = "";

            // Read user input
            Console.Write("Enter a positive number: ");
            positiveNumber = int.Parse(Console.ReadLine());

            for (int i = positiveNumber; i >= 1; i--)
            {
                message += $"\n\t {Math.Pow(i, 2)}";
            }

            // Display the result
            Console.WriteLine(message);

            // Wait for user input before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
