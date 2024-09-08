using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Example 5";

            // Declare variables
            int number1, number2, number3, result;

            // Read input
            Console.Write("\tGive a first number: ");
            number1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            Console.Write("\tGive a second number: ");
            number2 = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            Console.Write("\tGive a third number: ");
            number3 = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            // Perform operation
            if (number1 >= number2 && number1 > number3)
            {
                result = number1 - number3;

                // Display the result
                Console.WriteLine($"\n\t{number1} - {number3} = {result}");
            }

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
