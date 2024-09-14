using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class ValueAndRefParamsExample3
    {
        static void Main(string[] args)
        {
            Console.Title = "Value And Ref Params Example 3";

            // Declare variables
            int score = 45;          // Initial score
            double result = 0;       // Initial result

            // Call the  method Calculate, passing score and result by reference
            Calculate(ref score, ref result);

            // Display the new values of score and result
            Console.WriteLine($"The value of score is {score}");
            Console.WriteLine($"The value of result is {result:0.00}");

            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        // Method that calculates and modifies both score and result using ref parameters
        private static void Calculate(ref int points, ref double outcome)
        {
            // Calculate the result based on the initial value of points
            outcome = points * 7 / 3.0;

            // Ask the user for a new value for points
            Console.Write("Enter a new value for points: ");
            points = int.Parse(Console.ReadLine());  // Update points by reference
        }
    }
}
