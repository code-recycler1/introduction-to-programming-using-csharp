using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 7";

            // Declare array to store numbers
            int[] numbers = new int[4];

            // Read input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Give number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find the smallest number
            int lowest = numbers[0];  // Assume the first number is the smallest

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            // Build the output string
            string output = "From the set ";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0)
                {
                    if (i == numbers.Length - 1)
                    {
                        output += " and ";
                    }
                    else
                    {
                        output += ", ";
                    }
                }
                output += numbers[i];
            }
            output += $", the lowest number is {lowest}.";

            // Display the result
            Console.WriteLine($"\n{output}");

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
