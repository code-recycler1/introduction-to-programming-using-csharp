using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.Title = "Exercise 9";

            int number1, number2, number3;
            double result = 0; // Changed to double to handle square root results
            string letter, message;

            // Read input numbers
            Console.Write("Give a first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Give a second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Give a third number: ");
            number3 = int.Parse(Console.ReadLine());

            // Read operation code
            Console.Write("Choose a letter (A, B, C, D or another letter): ");
            letter = Console.ReadLine().ToLower();

            // Determine the operation based on the letter code
            switch (letter)
            {
                case "a":
                    result = number1 + number2 + number3;
                    message = $"{number1} + {number2} + {number3} = {result}";
                    break;
                case "b":
                    result = number1 * number3;
                    message = $"{number1} * {number3} = {result}";
                    break;
                case "c":
                    result = number3 - number2;
                    message = $"{number3} - {number2} = {result}";
                    break;
                case "d":
                    if (number1 > 0)
                    {
                        result = Math.Sqrt(number1);
                        message = $"The square root of {number1} is {result}";
                    }
                    else
                    {
                        message = "Sorry, we don't calculate the square roots of negative numbers or zero!";
                    }
                    break;
                default:
                    int highest = Math.Max(number1, Math.Max(number2, number3));
                    message = $"Highest number of set: {number1}, {number2}, {number3} ==> {highest}";
                    break;
            }

            // Display the result
            Console.WriteLine($"\n{message}");

            // Wait for user input before closing
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
