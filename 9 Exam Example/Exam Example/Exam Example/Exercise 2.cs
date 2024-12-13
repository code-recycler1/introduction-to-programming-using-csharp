using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Example
{
    internal class Exercise_2
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 2");

            // Get valid first number
            int number = Methods.GetValidNumber("Enter a first number: ");

            // Get valid conversion choice (1 for decimal-to-binary, 2 for binary-to-decimal)
            int choice = Methods.GetValidChoice("Enter a second number (1 for decimal-to-binary, 2 for binary-to-decimal): ");

            // Perform the conversion based on the user's choice
            string output = Methods.PerformConversion(number, choice);

            // Output the result
            Methods.PrintNotification($"The entered number is: {number}");
            Methods.PrintNotification($"The result is: {output}");

            Methods.PressEnter();
        }
    }
}
