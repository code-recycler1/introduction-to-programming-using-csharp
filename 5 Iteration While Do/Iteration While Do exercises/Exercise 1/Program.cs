using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Exercise 1 - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";

            //Declare variables
            string input, friends = "";

            // Ask if the user has any friends, ensure the answer is valid ("yes" or "no")
            do
            {
                Console.Write("Do you have any friends? (\"Yes\" or \"No\"): ");
                input = Console.ReadLine().ToLower();
            } while (input != "yes" && input != "no");  // Repeat until a valid response is entered

            // If the user answers "yes", ask for friend's names in a loop
            while (input == "yes")
            {
                Console.WriteLine();

                // Ask for the friend's name, making sure it is not empty or only spaces
                do
                {
                    Console.Write("Enter the first name of your friend: ");
                    input = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(input));  // Repeat until a valid name is provided

                // Add the valid friend's name to the list
                friends += $"\n\t{input}";

                // Ask if they have more friends and ensure a valid response
                do
                {
                    Console.Write("\nDo you have any other friends? (\"Yes\" or \"No\"): ");
                    input = Console.ReadLine().ToLower();
                } while (input != "yes" && input != "no");  // Repeat until a valid response is entered
            }

            // If no friends were added, print a sorry message in red and exit
            if (friends == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tSorry that you have no circle of friends!");
            }
            else
            {
                // If friends were added, print the list of friends in green
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMy circle of friends:");
                Console.WriteLine(friends);
            }

            // Reset the text color and wait for the user to press Enter to close the program
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
