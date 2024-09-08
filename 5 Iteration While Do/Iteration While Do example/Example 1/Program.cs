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
            // Set up the console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Example 1";

            // Declare variables
            string name, address;
            int numberOfLabels;

            // Ask the user how many labels they want to print, and store the response
            Console.Write("How many labels would you like to print? (0 = stop): ");
            numberOfLabels = int.Parse(Console.ReadLine());

            // Continue asking for details while the user wants to print labels (i.e., numberOfLabels is not 0)
            while (numberOfLabels != 0)
            {
                // Read the user's input for the name
                Console.Write("\nPlease provide the first and last name: ");
                name = Console.ReadLine();

                // Read the user's input for the address
                Console.Write($"\nPlease provide the address for {name.ToUpper()}: ");
                address = Console.ReadLine();

                // Clear the screen before printing the labels
                Console.Clear();

                // Loop to print the number of labels specified by the user
                for (int i = 1; i <= numberOfLabels; i++)
                {
                    // Print a label with a separator line above and below
                    Console.WriteLine($"\n{new string('-', 30)}");  // Print a dashed line as a separator
                    Console.ForegroundColor = ConsoleColor.Magenta;  // Change text color to magenta for the label
                    Console.WriteLine(name);  // Print the name
                    Console.WriteLine(address);  // Print the address
                    Console.ForegroundColor = ConsoleColor.DarkBlue;  // Reset text color back to dark blue
                    Console.WriteLine($"{new string('-', 30)}");  // Print another dashed line as a separator
                }

                // Ask the user again if they want to print more labels or stop (0 = stop)
                Console.Write("\nHow many labels would you like to print? (0 = stop): ");
                numberOfLabels = int.Parse(Console.ReadLine());  // Parse input as an integer
            }

            // End the program and wait for the user to press Enter before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
