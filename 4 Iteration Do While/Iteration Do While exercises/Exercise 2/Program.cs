using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set backgroundcolor to white
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.Title = $"Exercise 2 - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            double priceExcluded, priceIncluded, tax;
            int quantity = 5;
            string input;

            for (int i = 1; i <= quantity; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"\nArticle {i}\n");
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                // Ask the user for a price tax excluded
                do
                {
                    Console.Write("Price (tax excluded): ");
                    input = Console.ReadLine();

                } while (!double.TryParse(input, out priceExcluded) || priceExcluded <= 0);

                // Ask the user for the tax
                do
                {
                    Console.Write("Tax-%: ");
                    input = Console.ReadLine();

                } while (!double.TryParse(input, out tax) || tax < 0);

                priceIncluded = priceExcluded + (priceExcluded * tax / 100);

                Console.WriteLine($"\nPrice (tax included): {priceIncluded}");
            }

            // Wait for the user to press enter before exiting
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
