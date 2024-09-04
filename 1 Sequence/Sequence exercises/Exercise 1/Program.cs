using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the console appearance
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear(); // Clear the console to apply the colors
            Console.Title = "Exercise 1";

            // Declare variables
            int number1, number2, number3, number4, sum, product;

            // Read user input
            Console.Write("Give a first number: ");
            number1 = int.Parse(Console.ReadLine()); // Convert the input string to an integer

            Console.Write("Give a second number: ");
            number2 = Convert.ToInt32(Console.ReadLine()); // Also convert the input string to an integer

            Console.Write("Give a third number: ");
            number3 = int.Parse(Console.ReadLine());

            Console.Write("Give a fourth number: ");
            number4 = int.Parse(Console.ReadLine());

            // Calculate the sum and product
            sum = number1 + number3;
            product = number2 * number4;

            // Display the results
            Console.WriteLine();
            Console.WriteLine($"The sum of {number1} and {number3} is {sum}");
            Console.WriteLine($"The product of {number2} and {number4} is {product}");

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
