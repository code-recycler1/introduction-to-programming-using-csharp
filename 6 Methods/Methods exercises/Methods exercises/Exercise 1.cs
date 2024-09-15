using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            PrintTitle();

            activity = ReadActivity("\tFor which activity did you receive a text? (stop = none): ");

            while (activity.ToLower() != "none")
            {
                dateAndHourActivity = ReadDateTime(activity);

                areYouFree = IsAvailable(dateAndHourActivity);

                person = ReadPerson();

                answer = DetermineResponse(person.ToUpper(), areYouFree);

                // Display the result
                Console.WriteLine($"\n\tOn {dateAndHourActivity.ToLongDateString()} at {dateAndHourActivity.ToShortTimeString()} - {answer}\n");

                activity = ReadActivity("\tFor which activity did you receive a text? (stop = none): ");
            }

            // Wait for user to press Enter
            PressEnter();
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Exercise 1 - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private static void PrintTitle()
        {
            Console.WriteLine("\tReceived text message:\n");
        }

        private static string ReadActivity(string question)
        {
            string activity;

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

            do
            {
                Console.Write("\tWho send you the text message? ");
                person = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(person));

            return person;
        }

        private static string DetermineResponse(string name, bool isAvailable)
        {
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
            Console.WriteLine();
            Console.Write("\tPress enter to continue...");
            Console.ReadLine();
        }
        #endregion
    }
}
