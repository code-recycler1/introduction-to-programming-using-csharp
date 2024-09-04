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
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Example 1";

            // Declare variables
            string activity, dateAndHourActivity, answer;
            bool areYouFree;

            // Read input
            Console.WriteLine("\tReceived text message:");
            Console.Write("\n\tFor which activity did you receive a text? ");
            activity = Console.ReadLine(); // Read the activity name from the user

            Console.Write($"\tProvide the date and time when \"{activity}\" will take place: ");
            dateAndHourActivity = Console.ReadLine(); // Read the date and time of the activity

            Console.Write($"\tAre you free on {dateAndHourActivity} ('true' or 'false')? ");
            areYouFree = bool.Parse(Console.ReadLine());

            // Perform the selection operation
            if (areYouFree == true)
            {
                answer = "I will be there!";
            }
            else
            {
                answer = "Sorry, it will be another time!";
            }

            // Display the result
            Console.WriteLine($"\n\t{answer}");

            // Wait for user to press Enter
            Console.WriteLine();
            Console.Write("\tPress Enter to continue...");
            Console.ReadLine(); // Pause the program until the user presses Enter
        }
    }
}
