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
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 6";

            // Declare variables
            int number1, number2, start;
            string message = "";

            // Read user input
            Console.Write("Choose a number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Choose a second number: ");
            number2 = int.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                start = (number1 % 2 == 0) ? number1 : number1 + 1;

                for (int i = start; i <= number2; i += 2)
                {
                    if (i == start)
                    {
                        message += $"{start}";
                    }
                    else
                    {
                        message += $" * {i}";
                    }
                }
            }
            else
            {
                start = (number1 % 2 == 0) ? number1 : number1 - 1;

                for (int i = start; i >= number2; i -= 2)
                {
                    if (i == start)
                    {
                        message += $"{start}";
                    }
                    else
                    {
                        message += $" * {i}";
                    }
                }
            }

            Console.WriteLine($"\n{message}");

            // Wait for user input before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
