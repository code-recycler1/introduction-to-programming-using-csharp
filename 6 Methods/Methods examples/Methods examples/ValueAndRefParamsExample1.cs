using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class ValueAndRefParamsExample1
    {
        static void Main(string[] args)
        {
            Console.Title = "Value And Ref Params Example 1";

            // Declare variables
            int score = 77;  // Initial score
            double result;

            // Call the NewScore method with the 'score' variable passed by reference
            result = NewScore(ref score);

            // Output the result and the new value of 'score' after being modified by the method
            Console.WriteLine($"The value of result is {result}");
            Console.WriteLine($"The value of score is {score}");

            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        // Method with a ref parameter
        private static double NewScore(ref int points) // 'ref' means by reference, so the value in the main program can be changed
        {
            // Print the initial value of 'points'
            Console.WriteLine($"The value of points is {points}");

            // Ask the user for a new value for 'points'
            Console.Write("Enter a new value for points: ");
            points = int.Parse(Console.ReadLine()); // The new value entered by the user updates the original variable in Main()

            // Perform a calculation using the updated 'points'
            double outcome = points * 7.8;

            // Return the calculated result
            return outcome;
        }
    }
}
