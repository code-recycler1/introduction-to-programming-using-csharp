using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_7
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 7");

            string input = Methods.GetInput("Enter a word: ");
            string withoutVowels = Methods.RemoveVowels(input);

            Console.WriteLine($"The word without vowels is \"{withoutVowels}\".");

            Methods.PressEnter();
        }
    }
}
