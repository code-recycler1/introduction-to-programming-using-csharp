using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Example 4";

            // Declare variables
            string name, sex, title;
            int age;

            // Read user input
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write($"{name.ToUpper()}, what is your age? ");
            age = int.Parse(Console.ReadLine());

            Console.Write($"\n{name.ToLower()}, are you a woman or a man? (Enter \"W\", \"w\", \"M\", or \"m\"): ");
            sex = Console.ReadLine();

            if (sex.ToUpper() == "M")
            {
                if (age < 25)
                {
                    title = "young sir";
                }
                else
                {
                    title = "sir";
                }
            }
            else {
                if (age < 25)
                {
                    title = "young lady";
                }
                else
                {
                    title = "madam";
                }
            }

            // Display the result
            Console.WriteLine($"\n\tHello {title} {name}");

            // Wait for the user to press Enter
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
