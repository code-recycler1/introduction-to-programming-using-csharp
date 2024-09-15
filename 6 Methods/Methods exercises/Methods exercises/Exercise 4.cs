using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercises
{
    internal class Exercise_4
    {
        static void Main(string[] args)
        {
            // Set screen colors
            AdjustScreenColors();

            // Declare variables
            string traveler, companion, destination, messageDepartureDate;
            DateTime departureDate = DateTime.Today.AddMonths(2), returnDate,
            dateOfBirthTraveler, dateOfBirthCompanion = DateTime.Today;
            int numberOfNights = 7;

            // Prompt user for their name
            traveler = ReadName("Enter your name:");
            // Prompt user for their companion's name
            companion = ReadName($"\n(Fill in 'alone' if you are traveling solo)\nWho is your companion, {traveler}?");

            // Prompt user for their date of birth
            dateOfBirthTraveler = ReadDateOfBirth($"{traveler}, what is your date of birth?");

            messageDepartureDate = traveler;

            // If the user is not traveling alone, prompt for companion's date of birth
            if (companion.ToLower() != "alone")
            {
                dateOfBirthCompanion = ReadDateOfBirth($"What is the date of birth of \"{companion}\":");
                messageDepartureDate += $" and {companion}";
            }

            // Suggest a departure date
            messageDepartureDate += $", we suggest {departureDate.ToLongDateString()} as the departure date." +
                $" You can still change this date! ";

            // Prompt user for the destination
            destination = ReadDestination();

            // Allow user to adjust the departure date
            AdjustDepartureDate(messageDepartureDate, ref departureDate);
            // Allow user to adjust the number of nights
            AdjustNumberOfNights($"\nNumber of nights: {numberOfNights} days ", ref numberOfNights);

            // Calculate the return date based on departure date and number of nights
            returnDate = CalculateReturnDate(departureDate, numberOfNights);

            // Print the travel information
            PrintTravelInformation(traveler, companion, dateOfBirthTraveler, dateOfBirthCompanion, destination, departureDate, returnDate);

            // Wait for user to press Enter before closing
            PressEnter("Press enter to continue...");
        }

        #region Methods
        private static void AdjustScreenColors()
        {
            // Set the background color to white and text color to dark blue
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            // Set the console title to "Exercise 4"
            Console.Title = "Exercise 4";
        }

        private static void PressEnter(string message)
        {
            // Prompt the user to press Enter to continue
            Console.WriteLine();
            Console.Write(message);
            Console.ReadLine();
        }

        private static string ReadName(string question)
        {
            string name;

            // Prompt the user for a name until a valid input is received
            do
            {
                Console.Write($"{question} ");
                name = Console.ReadLine().ToUpper();
            } while (string.IsNullOrWhiteSpace(name) || name.Length < 2);

            return name;
        }

        private static DateTime ReadDate(string question)
        {
            string input;
            DateTime date;

            // Prompt the user for a date until a valid input is received
            do
            {
                Console.Write($"{question} ");
                input = Console.ReadLine();
            } while (!DateTime.TryParse(input, out date));

            return date;
        }

        private static DateTime ReadDateOfBirth(string question)
        {
            DateTime dateOfBirth;
            int maximumAge = 100;

            // Prompt the user for a date of birth until a valid input is received and the age is within a reasonable range
            do
            {
                dateOfBirth = ReadDate(question);
            } while (dateOfBirth > DateTime.Now || (DateTime.Now.Year - dateOfBirth.Year > maximumAge));

            return dateOfBirth;
        }

        private static void AdjustDepartureDate(string question, ref DateTime date)
        {
            string input;

            // Allow the user to adjust the departure date
            do
            {
                Console.WriteLine("\nIf the suggested date is okay, press enter! ");
                Console.Write(question);
                input = Console.ReadLine();

                if (input == string.Empty)
                {
                    input = date.ToShortDateString();
                }

            } while (!DateTime.TryParse(input, out date) || date < DateTime.Today.AddDays(1));
        }

        private static int ReadNumberOfDays(string question)
        {
            string input;
            int numberOfDays;

            // Prompt the user for the number of days until a valid input is received
            do
            {
                Console.Write(question);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out numberOfDays) || numberOfDays < 1);

            return numberOfDays;
        }

        private static void AdjustNumberOfNights(string message, ref int numberOfDays)
        {
            string input;

            // Allow the user to adjust the number of nights
            do
            {
                Console.WriteLine(message);
                Console.Write("Do you agree? Press 'Y' or 'N': ");
                input = Console.ReadLine().ToUpper();
            } while (input != "Y" && input != "N");

            if (input == "N")
            {
                numberOfDays = ReadNumberOfDays("Enter the desired number of nights (min. 1): ");
            }
        }

        private static string ReadDestination()
        {
            string input;

            // Prompt the user for the destination until a valid input is received
            do
            {
                Console.Write("Where is the trip going? ");
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        private static DateTime CalculateReturnDate(DateTime date, int numberOfDays)
        {
            // Calculate the return date based on the departure date and number of days
            DateTime returnDate = date.AddDays(numberOfDays);

            return returnDate;
        }

        private static void PrintTravelInformation(
            string participant1,
            string participant2,
            DateTime dateOfBirthParticipant1,
            DateTime dateOfBirthParticipant2,
            string destination,
            DateTime departureDate,
            DateTime returnDate)
        {
            string title = $"Travel Information: {destination}";

            // Clear the console and print the travel information
            Console.Clear();
            Console.WriteLine(title);
            Console.WriteLine(new string('-', title.Length));

            Console.WriteLine($"Participant(s): {participant1} born on {dateOfBirthParticipant1.ToLongDateString()}");

            if (participant2.ToLower() != "alone")
            {
                Console.WriteLine($"{new string(' ', 16)}{participant2} born on {dateOfBirthParticipant2.ToLongDateString()}");
            }

            Console.WriteLine($"\nDeparture date: {departureDate.ToLongDateString()}");
            Console.WriteLine($"Return date: {returnDate.ToLongDateString()}");
        }
        #endregion
    }
}
