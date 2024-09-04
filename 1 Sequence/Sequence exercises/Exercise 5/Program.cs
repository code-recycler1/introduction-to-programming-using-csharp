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
            Console.Title = "Exercise 5";

            // Declare variables
            double degreesCelsius, degreesFahrenheit;

            // Prompt user for input
            Console.WriteLine("Convert Celsius to Fahrenheit.");
            Console.WriteLine();
            Console.Write("Degrees Celsius: ");
            degreesCelsius = double.Parse(Console.ReadLine()); // Convert input string to a double

            // Calculate Fahrenheit using the formula
            degreesFahrenheit = degreesCelsius * 9 / 5 + 32;

            // Display the result
            Console.WriteLine();
            Console.WriteLine($"{degreesCelsius} degrees Celsius is {degreesFahrenheit:F2} degrees Fahrenheit."); // Format to 2 decimal places

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
