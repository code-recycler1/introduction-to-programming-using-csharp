using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To change the background color of the screen (Console)
            Console.BackgroundColor = ConsoleColor.White;
            // To change the foreground color of the screen, the color of the text
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            // Clears the console so the colors take effect immediately
            Console.Clear();
            // To change the content of the title bar of the screen.
            Console.Title = "Example 1";


            // Display a message AND goes to the next line
            Console.WriteLine("Hello, future C# developer!");
            // Adds a blank line for better spacing
            Console.WriteLine();

            // Display a message
            Console.Write("Press enter to continue!");
            // Wait for the user to press Enter to continue
            Console.ReadLine();
        }
    }
}
