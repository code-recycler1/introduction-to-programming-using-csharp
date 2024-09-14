using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class MethodWithReturnNoParams
    {
        static void Main(string[] args)
        {
            Console.Title = "Method With Return No Params";

            // Declare variables
            string firstName, lastName;
            double result;

            // Ask the user for a first and last name
            Console.Write("Enter a first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter a last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine();

            // Display the full name
            Console.WriteLine($"First name = {firstName} Last name = {lastName}");

            // Call the Calculate method, and store the result in the variable 'result'
            result = Calculate();

            // Display the result of the calculation
            Console.WriteLine($"The result of the calculation is {result}");

            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        // Method to do a simple calculation
        private static double Calculate() // Method with return value but no parameters
        {
            double outcome;
            // Perform a simple calculation
            outcome = 5 * 12 / 9.3;

            // Return the result of the calculation
            return outcome;
        }
    }
}
