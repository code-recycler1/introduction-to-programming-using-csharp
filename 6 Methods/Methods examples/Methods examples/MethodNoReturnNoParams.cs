using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class MethodNoReturnNoParams
    {
        static void Main(string[] args)
        {
            Console.Title = "Method No Return No Params";

            // Declare variables
            string firstName, lastName;

            // Ask the user for a first and last name
            Console.Write("Enter a first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter a last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine();

            // Call method to print the separator line (30 asterisks)
            PrintSeparator();

            // Display the full name and the current date and time
            Console.WriteLine($"First name = {firstName} Last name = {lastName}");
            Console.WriteLine($"The current date and time is {DateTime.Now}");

            // Call method to print the separator line again
            PrintSeparator();

            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        // Method to print a separator line of 30 asterisks
        private static void PrintSeparator() // Method with no return
        {
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Move to the next line after the separator
        }
    }
}
