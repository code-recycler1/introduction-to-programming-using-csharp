using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Example_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Example 6";

            // Declare variables
            string day, activity;

            // Read user input
            Console.Write("What day is it today? ('Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun') ");
            day = Console.ReadLine().ToLower();

            // Perform operation
            switch (day)
            {
                case "mon":
                    activity = "fishing";
                    break;
                case "tue":
                    activity = "swimming";
                    break;
                case "wed":
                    activity = "sailing";
                    break;
                default:
                    activity = "my own way";
                    break;
            }

            // Display the result
            Console.WriteLine($"\nToday, I'm going {activity}!");

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
