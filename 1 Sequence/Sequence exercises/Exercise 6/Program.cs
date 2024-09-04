using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 6";

            // Declare variables
            double height, wristCircumference, idealWeight;

            // Prompt user for input
            Console.Write("Height in centimeters: ");
            height = double.Parse(Console.ReadLine()); // Read and convert the height input to double

            Console.Write("Wrist circumference in centimeters: ");
            wristCircumference = double.Parse(Console.ReadLine()); // Read and convert the wrist circumference input to double

            // Calculate the ideal body weight using the formula
            idealWeight = (height + 4 * wristCircumference - 100) / 2;

            // Display the result
            Console.WriteLine();
            Console.WriteLine($"Ideal body weight: {idealWeight:F2} kg"); // Format to 2 decimal places and add unit

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
