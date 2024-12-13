using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Example
{
    public static class Methods
    {
        public static void AdjustScreenColors(string title)
        {
            // Set background and foreground colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // Set console title with current date and time
            Console.Title = $"{title} - {DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        public static void PressEnter()
        {
            Console.WriteLine();
            Console.Write("Press enter to continue!");
            Console.ReadLine();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("The processed data is:");
            Console.WriteLine(
                "Km".PadLeft(8) + "Liters".PadLeft(8) +
                "Km".PadLeft(8) + "Liters".PadLeft(8) +
                "Km".PadLeft(8) + "Liters".PadLeft(8) +
                "Km".PadLeft(8) + "Liters".PadLeft(8)
            );
        }

        public static double CalculateAverageFuelConsumption(double totalKm, double totalFuelConsumption)
        {
            return totalFuelConsumption / totalKm * 100;
        }

        public static void PrintData(double km, double liters, int count)
        {
            if (count % 4 == 0) // Newline after every 4 entries
            {
                Console.WriteLine(km.ToString().PadLeft(8) + liters.ToString().PadLeft(8));
            }
            else
            {
                Console.Write(km.ToString().PadLeft(8) + liters.ToString().PadLeft(8));
            }
        }

        public static void PrintNotification(string message)
        {
            Console.WriteLine();
            Console.WriteLine($"{message}");
        }

        public static void HandleFileExerciseOne(string filePath)
        {
            double totalKm = 0, totalFuelConsumption = 0, averageConsumption;
            int counter = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    double kilometers = double.Parse(reader.ReadLine());
                    double fuelConsumption = double.Parse(reader.ReadLine());

                    counter++;
                    totalKm += kilometers;
                    totalFuelConsumption += fuelConsumption;

                    PrintData(kilometers, fuelConsumption, counter);
                }
            }

            // Calculate and display the average fuel consumption
            averageConsumption = CalculateAverageFuelConsumption(totalKm, totalFuelConsumption);

            PrintNotification($"\nThe average fuel consumption is {averageConsumption:0.00} liters/100km");
        }

        public static int GetValidNumber(string prompt)
        {
            int number;
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) && number <=0); // Validate input using the provided function
            return number;
        }

        public static int GetValidChoice(string prompt)
        {
            int choice;
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
            } while (!int.TryParse(input, out choice) || (choice != 1 && choice != 2)); // Validate input using the provided function
            return choice; // Only allow choice 1 or 2
        }

        public static string PerformConversion(int number, int choice)
        {
            string output = string.Empty;
            switch (choice)
            {
                case 1: // Convert decimal to binary
                    ConvertToBinary(number.ToString(), ref output);
                    break;
                case 2: // Convert binary to decimal
                    output = ConvertToDecimal(number.ToString());
                    break;
            }
            return output;
        }

        public static string ConvertToDecimal(string binaryInput)
        {
            int length, power;
            double sum = 0;
            length = binaryInput.Length; // Length of binary string
            power = length - 1; // Power starts at length - 1

            for (int i = 0; i < length; i++)
            {
                string digitStr = binaryInput.Substring(i, 1); // Extract one binary digit
                int digit = int.Parse(digitStr); // Convert it to an integer
                sum += digit * Math.Pow(2, power); // Multiply by 2^power and add to sum
                power--; // Decrease the power
            }

            return sum.ToString(); // Return the decimal result as a string
        }

        public static void ConvertToBinary(string decimalInput, ref string result)
        {
            // Convert the decimal input to an integer
            int number = int.Parse(decimalInput);
            int remainder;

            // While the number is greater than 0, calculate binary digits
            while (number > 0)
            {
                remainder = number % 2; // Calculate the remainder (0 or 1)
                result = remainder.ToString() + result; // Add it to the result string
                number = number / 2; // Divide the number by 2 for the next iteration
            }
        }
    }
}
