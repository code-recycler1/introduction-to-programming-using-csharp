using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 4";

            // Declare variables
            int totalZonalCalls, totalInterzonalCalls;
            double costExcludingVAT, vatAmount, totalCost;

            // Read the number of zonal and interzonal calls from the user
            Console.Write("Total zonal calls: ");
            totalZonalCalls = int.Parse(Console.ReadLine()); // Convert input string to an integer

            Console.Write("Total interzonal calls: ");
            totalInterzonalCalls = int.Parse(Console.ReadLine()); // Convert input string to an integer

            // Calculate the total cost excluding VAT
            costExcludingVAT = totalZonalCalls * 0.12 + totalInterzonalCalls * 0.12 + 23;

            // Calculate the VAT amount
            vatAmount = costExcludingVAT * 0.21; // VAT rate of 21%

            // Calculate the total cost including VAT
            totalCost = costExcludingVAT + vatAmount;

            // Display the total amount
            Console.WriteLine();
            Console.WriteLine($"Total amount to be paid: {totalCost:F2}"); // Format to 2 decimal places

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
