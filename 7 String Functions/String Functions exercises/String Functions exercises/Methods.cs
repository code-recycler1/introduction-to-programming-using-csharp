using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    public static class Methods
    {
        public static void AdjustScreenColors(string title)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = $"{title} - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        public static string GetInput(string prompt)
        {
            string input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }

        public static int GetPositiveIntegerInput(string prompt)
        {
            int number;
            string input;

            do
            {
                input = GetInput(prompt);
            } while (!int.TryParse(input, out number) || number < 0);

            return number;
        }

        public static void PressEnter()
        {
            Console.WriteLine();
            Console.Write("Press enter to continue!");
            Console.ReadLine();
        }

        public static string Replace(string start, string x, string y)
        {
            string output = "";

            for (int i = 0; i < start.Length; i++)
            {
                string letter = start.Substring(i, 1);
                output += letter == x ? y : letter;
            }
            
            return output;
        }

        public static string RemoveVowels(string input)
        {
            string withoutVowels = "";

            foreach (char letter in input.ToLower())
            {
                if (!"aeiou".Contains(letter))
                {
                    withoutVowels += letter;
                }
            }
            
            return withoutVowels;
        }
    }
}
