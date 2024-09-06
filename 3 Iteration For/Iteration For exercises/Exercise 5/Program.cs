using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 5";

            // Declare variables
            int number1, number2;

            // Read user input
            Console.Write("Enter a first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = number1; i >= number2; i--)
            {
                if (i != number2)
                {
                    Console.Write($"{i} * ");
                }
                else
                {
                    Console.Write($"{i}\n");
                }
            }

            // Wait for user input before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
