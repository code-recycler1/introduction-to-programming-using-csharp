using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Methods_exercises_extra
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            // Set the console background, foreground color and title
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Exercise 1";

            // Declare variables
            string firstname, lastname, input;
            int count;

            // Print the title in red and uppercase
            Print("Print labels", ConsoleColor.Red, "upper");
            Console.WriteLine();

            // Prompt for the first name in blue without changing to uppercase
            Print("First name? ", ConsoleColor.Blue, "lower");
            firstname = Console.ReadLine();

            // Prompt for the last name in blue without changing to uppercase
            Print("Last name? ", ConsoleColor.Blue, "junk");
            lastname = Console.ReadLine();

            // Prompt for the number of labels and validate input
            do
            {
                Print("Number of labels", ConsoleColor.Blue, "upper");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out count));

            // Print the labels with alternating colors and cases
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(); // Add a newline before each label

                if (i % 2 == 0)
                {
                    Print(firstname + "\n" + lastname, ConsoleColor.Red, "upper");
                }
                else
                {
                    Print(firstname + "\n" + lastname, ConsoleColor.Black, "lower");
                }
            }

            // Prompt the user to press any key to exit
            Print("\nPress enter to continue...", ConsoleColor.Blue, "upper");
            Console.ReadLine();
        }

        private static void Print(string text, ConsoleColor foreground, string size)
        {
            // Set the console foreground color
            Console.ForegroundColor = foreground;

            // Convert the text to uppercase if 'size' is 'upper'
            if (size.ToLower() == "upper")
            {
                text = text.ToUpper();
            }

            // Print the text
            Console.WriteLine(text);
        }
    }
}
