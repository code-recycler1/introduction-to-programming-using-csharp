using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_exercises
{
    internal class Exercise_4
    {
        static void Main(string[] args)
        {
            // Adjust screen colors and set the title
            Methods.AdjustScreenColors("Exercise 4");

            int count = 11;
            string menu = Methods.ComposeMenu(count);

            // Read the user's choice from the menu
            int choice = Methods.ReadChoice(menu, count);

            while (choice != 0)
            {
                // Construct the filename based on the user's choice
                string filename = $"doc/poem{choice}.txt";

                // Check if the file exists
                if (!File.Exists(filename))
                {
                    // If the file does not exist, print a notification
                    filename = filename.Replace("doc/", "");
                    Methods.PrintDetail(information: $"\n\tFile \"{filename}\" does not exist!", newLine: true);
                }
                else
                {
                    // If the file exists, inform the user of their choice
                    Methods.PrintDetail($"\n\tYou chose {choice}!", true);
                    Methods.PressEnter();

                    // If the file exists, handle the file
                    Methods.HandleFileExerciseFour(filename);
                }

                // Prompt the user to press enter
                Methods.PressEnter();
                // Read the user's choice again
                choice = Methods.ReadChoice(menu, count);
            }

            // Prompt the user to press enter before closing the program
            Methods.PressEnter();
        }
    }
}
