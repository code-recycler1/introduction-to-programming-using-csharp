using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 7";

            // Declare variables for the contents of the boxes
            string redBox, blueBox, tempBox;

            // Read the contents of the red box from the user
            Console.Write("Enter the contents of the red box: ");
            redBox = Console.ReadLine(); // Store user input in redBox

            // Read the contents of the blue box from the user
            Console.Write("Enter the contents of the blue box: ");
            blueBox = Console.ReadLine(); // Store user input in blueBox

            // Display the values of the boxes
            Console.WriteLine();
            Console.WriteLine($"The value of the red box is {redBox} and the blue box is {blueBox}.");
            Console.WriteLine();
            Console.WriteLine("Swapping...");

            // Swap the contents of the boxes
            tempBox = redBox; // Use a temporary variable to hold the value of redBox
            redBox = blueBox; // Assign the value of blueBox to redBox
            blueBox = tempBox; // Assign the original value of redBox (stored in tempBox) to blueBox

            // Display the new values of the boxes
            Console.WriteLine();
            Console.WriteLine($"The new value of the red box is {redBox} and the blue box is {blueBox}.");

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
