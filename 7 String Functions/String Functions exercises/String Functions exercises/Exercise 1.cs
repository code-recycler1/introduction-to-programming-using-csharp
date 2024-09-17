using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 1");

            string input = Methods.GetPositiveIntegerInput("Enter a number: ").ToString();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int numberPart = int.Parse(input.Substring(i, 1));
                sum += numberPart;
            }

            Console.WriteLine($"The sum of the digits is {sum}.");

            Methods.PressEnter();
        }
    }
}
