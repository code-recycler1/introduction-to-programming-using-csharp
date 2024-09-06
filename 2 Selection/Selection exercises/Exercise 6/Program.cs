using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 6";

            // Declare variables
            int year;
            string message;

            Console.WriteLine("\tDetermine if a year is a leap year!");

            // Read the year from user input
            Console.Write("\tEnter a year: ");
            year = int.Parse(Console.ReadLine());

            // Begin the message
            message = $"{year} is ";

            // Logic for leap year before 1582
            if (year < 1582)
            {
                if (year % 4 != 0)
                {
                    message += "not ";
                }

                message += "a leap year";
            }
            else // Logic for year >= 1582
            {
                if (year % 4000 == 0)
                {
                    message += "not a "; // Divisible by 4000, not a leap year
                }
                else if (year % 400 == 0)
                {
                    message += "a "; // Divisible by 400, leap year
                }
                else if (year % 100 == 0)
                {
                    message += "not a "; // Divisible by 100, not a leap year
                }
                else if (year % 4 == 0)
                {
                    message += "a "; // Divisible by 4, leap year
                }
                else
                {
                    message += "not a "; // Otherwise, not a leap year
                }

                message += "leap year";
            }

            // Display the result
            Console.WriteLine($"\n\t{message}");

            // Wait for the user to press Enter
            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();
        }
    }
}
