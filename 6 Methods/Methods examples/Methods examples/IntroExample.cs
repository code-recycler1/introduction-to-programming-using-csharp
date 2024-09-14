using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class IntroExample
    {
        static void Main(string[] args)
        {
            Console.Title = "Intro Example";

            // Declare variables
            string firstName, lastName;

            // Ask the user for a first and last name
            Console.Write("Enter a first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter a last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine();

            // Print a seperator of 30 asterisks
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            // Display the full name and the current date and time
            Console.WriteLine($"First name = {firstName} Last name = {lastName}");
            Console.WriteLine($"The current date and time is {DateTime.Now}");

            // Print a seperator of 30 asterisks
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
