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
            Console.Title = "Exercise 3"; // Set the console title

            // Declare variables
            int age;
            string firstname, lastname, ageGroup = "Adult"; // Default to "Adult"

            // Read user input
            Console.Write("Your first name: ");
            firstname = Console.ReadLine();

            Console.Write($"{firstname}, put in your last name: ");
            lastname = Console.ReadLine();

            // Ask for the age
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{firstname} {lastname}");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(", what is your age? ");
            age = int.Parse(Console.ReadLine()); // Parse the input as an integer

            Console.Write($"\n{firstname} {lastname} belongs to the age group: ");

            // Check if age is less than 18
            if (age < 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                ageGroup = "Youth"; // Change the age group to "Youth" if age < 18
            }

            // Output the age group result
            Console.WriteLine($"{ageGroup}");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine(); // Wait for the user to press enter before exiting

        }
    }
}
