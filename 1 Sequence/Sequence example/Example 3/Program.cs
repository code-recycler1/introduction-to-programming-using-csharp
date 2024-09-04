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
            // To change the background color of the screen (Console)
            Console.BackgroundColor = ConsoleColor.White;
            // To change the foreground color of the screen, the color of the text
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            // Clears the console so the colors take effect immediately
            Console.Clear();
            // To change the content of the title bar of the screen.
            Console.Title = "Example 2";

            // Declare variables
            int number1 = 15, number2 = 4, quotient1;
            double number3 = 15, number4 = 4, quotient2, quotient3, quotient4;

            // Calculate the quotient
            quotient1 = number1 / number2;
            quotient2 = number1 / number2;
            quotient3 = number1 / number4;
            quotient4 = number3 / number2;
            
            // Display the results
            Console.WriteLine($"int / int = int \t {number1} / {number2} = {quotient1}"); // Not the quotient we want
            Console.WriteLine($"int / int = double \t {number1} / {number2} = {quotient2}"); // Not the quotient we want
            Console.WriteLine($"int / double = double \t {number1} / {number3} = {quotient3}"); // The quotient we want
            Console.WriteLine($"double / int = double \t {number3} / {number2} = {quotient4}"); // The quotient we want

            Console.WriteLine();
            Console.Write("Press enter to continue!");
            // Wait for the user to press Enter to continue
            Console.ReadLine();
        }
    }
}
