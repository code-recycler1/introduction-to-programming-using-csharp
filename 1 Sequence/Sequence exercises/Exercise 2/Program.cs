using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 2";

            // Declare variables
            double priceExcluded, priceIncluded;
            int tax;

            // Read the price excluding VAT from the user
            Console.Write("Price (tax excluded): ");
            priceExcluded = double.Parse(Console.ReadLine()); // Convert input string to a double

            // Read the VAT percentage from the user
            Console.Write("Tax-%: ");
            tax = int.Parse(Console.ReadLine()); // Convert input string to an integer

            // Calculate the price including VAT
            priceIncluded = priceExcluded * (1 + tax / 100.0); // Use 100.0 to ensure floating-point division

            // Display the result
            Console.WriteLine();
            Console.WriteLine($"Price (tax included): {priceIncluded:F2}"); // Format to 2 decimal places

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
