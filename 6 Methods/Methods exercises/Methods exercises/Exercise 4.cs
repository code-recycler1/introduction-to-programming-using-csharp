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


            traveler = ReadName("Enter your name:");
            companion = ReadName($"\n(Fill in 'alone' if you are traveling solo)\nWho is your companion, {traveler}?");

            dateOfBirthTraveler = ReadDateOfBirth($"{traveler}, what is your date of birth?");

            messageDepartureDate = traveler;

            if (companion.ToLower() != "alone")
            {
                dateOfBirthCompanion = ReadDateOfBirth($"What is the date of birth of \"{companion}\":");
                messageDepartureDate += $" and {companion}";
            }

            messageDepartureDate += $", we suggest {departureDate.ToLongDateString()} as the departure date." +
                $" You can still change this date! ";

            destination = ReadDestination();

            AdjustDepartureDate(messageDepartureDate, ref departureDate);
            AdjustNumberOfNights($"\nNumber of nights: {numberOfNights} days ", ref numberOfNights);

            returnDate = CalculateReturnDate(departureDate, numberOfNights);

            PrintTravelInformation(traveler, companion, dateOfBirthTraveler, dateOfBirthCompanion, destination, departureDate, returnDate);

            PressEnter("Press enter to continue...");
        }

        #region Methodes
        private static void AdjustScreenColors()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 4";
        }

        private static void PressEnter(string boodschap)
        {
            Console.WriteLine();
            Console.Write(boodschap);
            Console.ReadLine();
        }

        private static string ReadName(string question)
        {
            string name;

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

            do
            {
                dateOfBirth = ReadDate(question);
            } while (dateOfBirth > DateTime.Now || (DateTime.Now.Year - dateOfBirth.Year > maximumAge));

            return dateOfBirth;
        }

        private static void AdjustDepartureDate(string question, ref DateTime date)
        {
            string input;

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

            do
            {
                Console.Write("Where is the trip going? ");
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        private static DateTime CalculateReturnDate(DateTime date, int numberOfDays)
        {
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
