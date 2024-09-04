using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Example 2";

            // Declare variables
            int number1, number2, result;
            string operatorCode;

            // Read input
            Console.Write("\tGive a first number: ");
            number1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            Console.Write("\tGive a second number: ");
            number2 = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            // Perform operation
            if (number1 >= number2)
            {
                result = number1 - number2;
                operatorCode = "-";
            }
            else
            {
                result = number1 + number2;
                operatorCode = "+";
            }

            // Display the results
            Console.WriteLine($"\n\t{number1} {operatorCode} {number2} = {result}");

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
