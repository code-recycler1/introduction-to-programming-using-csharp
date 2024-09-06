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
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Exercise 2";

            // Declare variables
            string name, message;
            int luckynumber;

            // Read user input
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("What is your lucky number? ");
            luckynumber = int.Parse(Console.ReadLine());

            message = $"\n{luckynumber}";

            for (int i = 1; i <= luckynumber; i++)
            {
                message += $" {name}";
            }

            Console.WriteLine(message);

            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
