using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class ValueAndRefParamsExample2
    {
        static void Main(string[] args)
        {
            Console.Title = "Value And Ref Params Example 2";

            // Declare variables
            int score = 77; // Initial score

            // Call the NeweScore method with the 'score' variable passed by reference
            NewScore(ref score);

            // Display the new value of 'score' after being modified by the method
            Console.WriteLine($"The value of score is {score}");

            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        // Method that modifies the score using a ref parameter
        private static void NewScore(ref int points)
        {
            // Print the initial value of 'points'
            Console.WriteLine($"The value of points is {points}");

            // Ask the user for a new value for 'points'
            Console.Write("Enter a new value for points: ");
            points = int.Parse(Console.ReadLine()); // The new value entered by the user updates the original variable in Main()
        }
    }
}
