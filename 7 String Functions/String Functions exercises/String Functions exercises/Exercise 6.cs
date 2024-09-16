using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_6
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 6");

            string prompt1 = "Enter word 1: ";
            string word1 = Methods.GetInput(prompt1);
            string word2 = Methods.GetInput("Enter word 2: ");

            int length = Math.Min(word1.Length, word2.Length);
            string result = new string(' ', prompt1.Length);

            for (int i = 0; i < length; i++)
            {
                string letter1 = word1.Substring(i, 1).ToLower();
                string letter2 = word2.Substring(i, 1).ToLower();
                result += letter1 == letter2 ? '-' : ' ';
            }

            Console.WriteLine(result);

            Methods.PressEnter();
        }
    }
}
