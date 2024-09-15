using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Methods_exercises
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            // Set screen colors
            AdjustScreenColors();

            // Declare variables
            string activity, answer, person;
            bool areYouFree;
            DateTime dateAndHourActivity;

            // Print the title of the program
            PrintTitle();

            // Prompt user for the activity
            activity = ReadActivity("\tFor which activity did you receive a text? (stop = none): ");

            // Loop until the user enters "none"
            while (activity.ToLower() != "none")
            {
                // Read the date and time of the activity
                dateAndHourActivity = ReadDateTime(activity);

                // Check if the user is available at that date and time
                areYouFree = IsAvailable(dateAndHourActivity);

                // Read the name of the person who sent the text
                person = ReadPerson();

                // Determine the response based on availability
                answer = DetermineResponse(person.ToUpper(), areYouFree);

                // Display the result
                Console.WriteLine($"\n\tOn {dateAndHourActivity.ToLongDateString()} at {dateAndHourActivity.ToShortTimeString()} - {answer}\n");

                // Prompt user for the next activity
                activity = ReadActivity("\tFor which activity did you receive a text? (stop = none): ");
            }

            // Wait for user to press Enter before closing
            PressEnter();
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            // Set the background color to white and text color to dark blue
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            // Set the console title to include the current date and time
            Console.Title = $"Exercise 1 - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private static void PrintTitle()
        {
            // Print the title of the program
            Console.WriteLine("\tReceived text message:\n");
        }

        private static string ReadActivity(string question)
        {
            string activity;

            // Prompt the user for the activity until a valid input is received
            do
            {
                Console.Write(question);
                activity = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(activity));

            return activity;
        }

        private static DateTime ReadDateTime(string activity)
        {
            string input;
            DateTime dateAndHourActivity;

            // Prompt the user for the date and time of the activity until a valid input is received
            do
            {
                Console.Write($"\tProvide the date and time when \"{activity}\" will take place: ");
                input = Console.ReadLine();
            } while (DateTime.TryParse(input, out dateAndHourActivity) == false || dateAndHourActivity < DateTime.Now);

            return dateAndHourActivity;
        }

        private static bool IsAvailable(DateTime dateAndHourActivity)
        {
            string input;
            bool areYouFree;

            // Prompt the user to check if they are free at the given date and time until a valid input is received
            do
            {
                Console.Write($"\tAre you free on {dateAndHourActivity} ('true' or 'false')? ");
                input = Console.ReadLine();
            } while (!bool.TryParse(input, out areYouFree));

            return areYouFree;
        }

        private static string ReadPerson()
        {
            string person;

            // Prompt the user for the name of the person who sent the text until a valid input is received
            do
            {
                Console.Write("\tWho send you the text message? ");
                person = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(person));

            return person;
        }

        private static string DetermineResponse(string name, bool isAvailable)
        {
            // Return the appropriate response based on availability
            if (isAvailable)
            {
                return $"{name}, I will be there!";
            }
            else
            {
                return $"{name}, sorry, it will be another time!";
            }
        }

        private static void PressEnter()
        {
            // Prompt the user to press Enter to continue
            Console.WriteLine();
            Console.Write("\tPress enter to continue...");
            Console.ReadLine();
        }
        #endregion
    }
}
