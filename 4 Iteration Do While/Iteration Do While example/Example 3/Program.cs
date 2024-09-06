using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = $"Example 3 {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";

            // Declare variables
            string name = "John Doe", letter = "B", _object = "pencil      ";

            // Display the result
            Console.WriteLine($"\n\tname contains {name.Length} characters: '{name}'");
            Console.WriteLine($"\tletter contains {letter.Length} characters: '{letter}'");
            Console.WriteLine($"\tobject contains {_object.Length} characters: '{_object}'");

            Console.WriteLine();

            Console.WriteLine($"\t{new string('*', name.Length)}");
            Console.WriteLine($"\t{new string('-', letter.Length)}");
            Console.WriteLine($"\t{new string('=', _object.Length)}");

            Console.WriteLine();

            Console.WriteLine($"\t{name}");
            Console.WriteLine($"\t{new string('*', name.Length)}");
            Console.WriteLine($"\t{letter}");
            Console.WriteLine($"\t{new string('-', letter.Length)}");
            Console.WriteLine($"\t{_object}");
            Console.WriteLine($"\t{new string('=', _object.Length)}");

            Console.WriteLine();

            // Wait for user to press Enter
            Console.WriteLine();
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
