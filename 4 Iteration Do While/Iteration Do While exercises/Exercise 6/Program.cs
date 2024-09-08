using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up the console appearance and title
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = $"Exercise 6 - {DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";

            // Declare variables
            int minimum, maximum, guess, counter, lotteryball, quantity = 3;
            string input;

            // Create a new random number generator
            Random random = new Random();

            // Get the minimum value from the user
            do
            {
                Console.Write("Enter a minimum value: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out minimum));

            // Get the maximum value from the user, ensuring it is greater than the minimum
            do
            {
                Console.Write($"Enter a maximum value higher than {minimum}: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out maximum) || maximum <= minimum);

            // Start guessing loop for the number of attempts (3 times)
            for (int i = 1; i <= quantity; i++)
            {
                // Generate a random number between the minimum and maximum (inclusive)
                lotteryball = random.Next(minimum, maximum + 1);

                // Notify the user which lottery ball number we're on
                Console.WriteLine($"\nLottery ball {i}\n");
                counter = 0;

                // Begin the guessing process
                do
                {
                    counter++; // Increment the guess counter for each attempt

                    Console.Write($"Guess the number on the lottery ball (between {minimum} and {maximum}): ");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out guess) || lotteryball != guess);

                // Display how many attempts the user needed, adjusting for singular/plural
                Console.WriteLine($"\nYou guessed correctly in {counter} attempt{(counter == 1 ? "" : "s")}!");
            }

            // Wait for user input to close the program
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
