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
            int length, width;
            string title = "Supporterscraf", symbol1, symbol2;

            Console.WriteLine(title);
            Console.WriteLine(new string('*', title.Length));

            // Read user input
            Console.Write("Choose symbol 1: ");
            symbol1 = Console.ReadLine();

            Console.Write("Choose symbol 2: ");
            symbol2 = Console.ReadLine();

            Console.Write("How long does the scarf need to be? ");
            length = int.Parse(Console.ReadLine());

            Console.Write("How wide does the scarf need to be? ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = length; i > 0; i--)
            {
                for (int j = width; j > 0; j--)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(symbol1);
                    }
                    else
                    {
                        Console.Write(symbol2);
                    }
                }

                Console.WriteLine();
            }

            // Wait for user input before closing
            Console.WriteLine("\n\nPress enter to continue...");
            Console.ReadLine();
        }
    }
}
