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
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 4";

            // Declare variables
            int number1, number2, number3, first = 0, second = 0, result;
            string letter, figure, message;

            // Read input from user
            Console.Write("Give a first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Give a second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Give a third number: ");
            number3 = int.Parse(Console.ReadLine());

            Console.Write("Choose a letter (A or B): ");
            letter = Console.ReadLine().ToUpper(); // Convert input to uppercase

            Console.Write("Choose a figure (1, 2, or 3): ");
            figure = Console.ReadLine();

            // Determine the first and second numbers based on the figure
            switch (figure)
            {
                case "1":
                    first = number1;
                    second = number2;
                    break;
                case "2":
                    first = number2;
                    second = number3;
                    break;
                case "3":
                    first = number1;
                    second = number3;
                    break;
                default:
                    Console.WriteLine("Invalid figure input.");
                    Console.WriteLine("\nPress enter to exit...");
                    Console.ReadLine();
                    return;
            }

            // Perform operation based on the letter code
            if (letter == "A")
            {
                result = first + second;
                message = $"{first} + {second} = {result}";
            }
            else if (letter == "B")
            {
                result = first - second;
                message = $"{first} - {second} = {result}";
            }
            else
            {
                Console.WriteLine("Invalid letter input.");
                Console.WriteLine("\nPress enter to exit...");
                Console.ReadLine();
                return;
            }

            // Display the result
            Console.WriteLine($"\n{message}");

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
