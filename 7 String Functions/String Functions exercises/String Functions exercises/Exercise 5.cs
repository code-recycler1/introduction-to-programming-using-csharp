using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_5
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 5");

            string input = Methods.GetInput("Enter a word: ");
            string prompt = "Enter a word: ";

            Console.Write(new string(' ', prompt.Length));
            Console.WriteLine(new string('*', input.Length));

            Methods.PressEnter();
        }
    }
}
