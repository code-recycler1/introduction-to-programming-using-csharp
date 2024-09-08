using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = $"Exercise 5 {DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            int arrowLanded, score = 0, quantity = 3;
            string input, summary = "\n\t1. Arrow lands outside the board (0 points)" +
                                    "\n\t2. Arrow lands in the outer ring (20 points)" +
                                    "\n\t3. Arrow lands in the inner ring (50 points)" +
                                    "\n\t4. Arrow lands in the bullseye (100 points)";

            for (int i = 1; i <= quantity; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"\tArrow {i}");
                    Console.WriteLine(summary);
                    Console.Write("\n\tWhere did your arrow land? ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out arrowLanded) || arrowLanded < 1 || arrowLanded > 4);

                // Add points based on where the arrow lands
                switch (arrowLanded)
                {
                    case 1:
                        score += 0;   // Outside the board
                        break;
                    case 2:
                        score += 20;  // Outer ring
                        break;
                    case 3:
                        score += 50;  // Inner ring
                        break;
                    case 4:
                        score += 100; // Bullseye
                        break;
                }
            }

            // Display the result
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n\tYou scored a total of {score} points!");
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Wait for the user to press enter before exiting
            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();
        }
    }
}
