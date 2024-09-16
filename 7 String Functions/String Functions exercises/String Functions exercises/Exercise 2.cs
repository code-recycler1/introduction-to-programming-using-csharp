using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_exercises
{
    internal class Exercise_2
    {
        static void Main(string[] args)
        {
            Methods.AdjustScreenColors("Exercise 2");

            string accountNumber, accountNumberWithoutSpaces, message;

            do
            {
                accountNumber = Methods.GetInput("Enter an account number: ");
                accountNumberWithoutSpaces = accountNumber.Replace(" ", "");
            }
            while (accountNumberWithoutSpaces.Length != 16 || accountNumber.IndexOf("BE") != 0 || !long.TryParse(accountNumberWithoutSpaces.Substring(3), out long rn));

            accountNumber = accountNumber.Substring(5).Replace(" ", "");

            string part1 = accountNumber.Substring(0, 10);
            string part2 = accountNumber.Substring(10);

            long number = long.Parse(part1);
            int control = int.Parse(part2);
            long remainder = number % 97;

            if (remainder == 0)
            {
                remainder = 97;
            }

            message = remainder == control ? "Account number is OK" : "Account number is not OK";

            Console.WriteLine($"\n{message}");

            Methods.PressEnter();
        }
    }
}
