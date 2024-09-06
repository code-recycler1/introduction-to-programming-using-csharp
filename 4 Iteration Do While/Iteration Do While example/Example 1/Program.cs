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
            Console.Title = $"Example 1 {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";

            // Declare variables
            string activity, input, answer;
            bool areYouFree;
            DateTime dateAndHourActivity;

            // Read input
            Console.WriteLine("Received text message:\n");

            // Read the activity name from the user
            // Keep asking if the activity is blank or spaces
            do
            {
                Console.Write("\tFor which activity did you receive a text? ");
                activity = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(activity));

            // Read the date and hour from the user
            // Keep asking if the input is not the right format or if it is not a date in the future
            do
            {
                Console.Write($"\tProvide the date and time when \"{activity}\" will take place: ");
                input = Console.ReadLine(); // Read the date and time of the activity
            } while (!DateTime.TryParse(input, out dateAndHourActivity) || dateAndHourActivity < DateTime.Now);

            // Read the availability from the user
            // Keep asking if the input is not true or false
            do
            {
                Console.Write($"\tAre you free on {dateAndHourActivity} ('true' or 'false')? ");
                input = Console.ReadLine();
            } while (!bool.TryParse(input, out areYouFree));


            if (areYouFree)
            {
                answer = "I will be there!";
            }
            else
            {
                answer = "Sorry, it will be another time!";
            }

            // Display the result
            Console.WriteLine($"\n\tOn {dateAndHourActivity.ToLongDateString()} at {dateAndHourActivity.ToShortTimeString()} - {answer}");

            // Wait for user to press Enter
            Console.WriteLine();
            Console.Write("\tPress enter to continue...");
            Console.ReadLine();
        }
    }
}
