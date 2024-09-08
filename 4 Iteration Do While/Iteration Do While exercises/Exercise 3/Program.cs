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
            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = $"Exercise 3 {DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            int quantity = 4, age;
            string input, firstname, lastname, ageGroup = "";
            DateTime dob;

            Console.WriteLine($"We are going to determine the age group of {quantity} persons!\n");

            for (int i = 1; i <= quantity; i++)
            {
                // Input first name
                do
                {
                    Console.Write($"Person {i}, enter your first name: ");
                    firstname = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(firstname));

                // Input last name
                do
                {
                    Console.Write($"{firstname}, enter your last name: ");
                    lastname = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(lastname));

                // Input date of birth and validate
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{firstname} {lastname}");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(", enter your date of birth (dd/mm/yyyy): ");
                    input = Console.ReadLine();
                } while (!DateTime.TryParse(input, out dob) || DateTime.Now < dob);

                // Adjust age calculation to account for birthdays that haven't occurred yet this year
                age = DateTime.Now.Year - dob.Year;
                if (DateTime.Now < dob.AddYears(age))
                {
                    age--;
                }

                // Determine the age group
                if (age >= 18)
                {
                    ageGroup = "Adult";
                }
                else if (age >= 10)
                {
                    ageGroup = "Teenager";
                }
                else if (age >= 3)
                {
                    ageGroup = "Toddler";
                }
                else if (age >= 0)
                {
                    ageGroup = "Baby";
                }

                // Output the result
                Console.Write($"\n{firstname} {lastname} - {age} years old belongs to age group: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{ageGroup}\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            // Wait for the user to press enter before exiting
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
