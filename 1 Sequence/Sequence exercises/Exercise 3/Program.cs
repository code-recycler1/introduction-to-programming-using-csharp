using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 3";

            // Declare variables for number of adults and children
            int adultTotal, kidTotal;
            // Declare constants for the cost of admission
            const double costAdult = 10.0;
            const double costKid = 7.5;
            double costTotal;

            // Read the number of adults from the user
            Console.Write("Total adults: ");
            adultTotal = int.Parse(Console.ReadLine()); // Convert input string to an integer

            // Read the number of children from the user
            Console.Write("Total kids: ");
            kidTotal = int.Parse(Console.ReadLine()); // Convert input string to an integer

            // Calculate the total cost
            costTotal = (costAdult * adultTotal) + (costKid * kidTotal);

            // Display the total entrance fee
            Console.WriteLine();
            Console.WriteLine($"Total entrance fee: {costTotal:F2}"); // Format to 2 decimal places

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
