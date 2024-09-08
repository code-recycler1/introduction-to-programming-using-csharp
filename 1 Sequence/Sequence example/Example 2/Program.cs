using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
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
            Console.Title = "Example 2";

            // Declare variables
            string name = "Doe";
            string surname = "John";

            // Display a message
            Console.Write("My name is " + name + ", ");
            // Display a message AND goes to the next line
            Console.WriteLine("my surname is " + surname + "!");
            // Adds a blank line for better spacing
            Console.WriteLine();
            // Display a message AND goes to the next line
            Console.WriteLine("My fullname is {0} {1}!", surname, name);
            // Adds a blank line for better spacing
            Console.WriteLine();

            Console.Write("Press enter to continue!");
            // Wait for the user to press Enter to continue
            Console.ReadLine();
        }
    }
}
