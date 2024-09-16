using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_4
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 4");

            string input = Methods.GetInput("Enter a word: ").ToLower();
            string output1 = input.Replace("o", "x");

            Console.WriteLine($"\nWe replace \"o\" with \"x\": \"{output1}\"");

            string output2 = Methods.Replace(output1, "x", "p");
            Console.WriteLine($"\nWe replace \"x\" with \"p\": \"{output2}\"");

            Methods.PressEnter();
        }
    }
}
