using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set screen colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = $"Exercise 4 {DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            int counter = 0;
            string input;

            string title = "Pay attention and look carefully at this sentence!";
            string sentence = "On the chair there is a sun hat and gingerbread.";

            // First screen
            Console.WriteLine($"\t{title}");
            Console.WriteLine($"\t{new string('-', title.Length)}");
            Console.WriteLine($"\t{sentence}");

            Console.WriteLine("\n\tPress enter to continue...");
            Console.ReadLine();

            Console.Clear();

            // Second screen
            Console.WriteLine("Please reproduce the sentence you studied on the previous screen!\n");

            do
            {
                counter++;
                Console.Write($"Attempt {counter}: ");
                input = Console.ReadLine();

            } while (input != sentence);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYou needed {counter} attempt{(counter == 1 ? "" : "s")} to reproduce the sentence correctly!");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Wait for the user to press enter before exiting
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
