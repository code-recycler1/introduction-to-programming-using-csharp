using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Example 1";

            // Declare variables
            int number, numberOfPrints;
            string output;

            // Read user input
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            Console.Write("Enter the desired number of prints: ");
            numberOfPrints = int.Parse(Console.ReadLine());

            output = "\n";

            for (int i = 0; i < numberOfPrints; i++)
            {
                output += $"\t{number}\n";
            }

            // Display the result
            Console.WriteLine(output);

            // Wait for user input before closing
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
