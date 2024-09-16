using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_3
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 3");

            string input = Methods.GetInput("Enter a word: ");
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                output = output.Insert(0, input.Substring(i, 1));
            }

            string result = input == output ? "a" : "not a";
            Console.WriteLine($"\"{input}\" is {result} palindrome.");

            Methods.PressEnter();
        }
    }
}
