using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_exercises_extra
{
    internal class Exercise_3
    {
        static void Main(string[] args)
        {
            // Set the console title
            Console.Title = "Exercise 3";

            // Print instructions for the user
            Console.WriteLine("Enter a subject and then the score for each subject.");
            Console.WriteLine();

            // Declare variables
            string subjectName = "";
            double subjectScore = 0;
            double totalScore = 0;

            // Loop to read and process 5 subjects
            for (int i = 1; i <= 5; i++)
            {
                // Read the subject name and score
                ReadSubject(i, ref subjectName, ref subjectScore);
                // Process the subject and score
                Process(subjectName, subjectScore);
                // Add the score to the total score
                totalScore += subjectScore;
            }

            // Calculate the final percentage based on the total score
            double finalPercentage = (totalScore / 100) * 100;
            Console.WriteLine();
            // Print the final percentage
            Console.WriteLine($"-> Final percentage: {finalPercentage:0.0}%");
            Console.ReadLine();
        }

        private static void Process(string subjectName, double subjectScore)
        {
            Console.WriteLine();
            // Set the text color to blue
            Console.ForegroundColor = ConsoleColor.Blue;
            // Print the subject name in lowercase
            Console.WriteLine(new string(' ', 10) + subjectName.ToLower());
            // Print the score out of 20
            Console.WriteLine(new string(' ', 10) + $"score {subjectScore}/20");
            Console.Write(new string(' ', 10) + "this is ");

            // Calculate the percentage score
            double percentage = (subjectScore / 20) * 100;

            // Set the text color based on the score
            if (subjectScore < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            // Print the percentage score
            Console.WriteLine($"{percentage:0.0}%\n");
            // Reset the text color to white
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ReadSubject(int subjectNumber, ref string subjectName, ref double subjectScore)
        {

            // Prompt the user for the subject name until a valid input is received
            do
            {
                Console.Write($"Subject {subjectNumber}? ");
                subjectName = Console.ReadLine();
            } while (string.IsNullOrEmpty(subjectName));

            string input;

            // Prompt the user for the score until a valid input is received
            do
            {
                Console.Write($"Score out of 20 for {subjectName.ToUpper()}: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out subjectScore) || subjectScore < 0 || subjectScore > 20);
        }
    }
}
