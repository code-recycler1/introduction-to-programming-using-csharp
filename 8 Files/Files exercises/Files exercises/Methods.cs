using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Files_exercises
{
    internal class Methods
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
            // Set message color to dark blue
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();

            // Print message and wait for user to press enter
            Console.Write("\tPress enter to continue!");
            Console.ReadLine();
        }

        public static void PrintNotification(string message)
        {
            // Clear the console and print the notification message
            Console.Clear();
            Console.WriteLine($"\t{message}");
        }

        #region Exercise 1
        public static void ReadFileExerciseOne(string filename, ref string overview)
        {
            // Open the file for reading
            using (StreamReader reader = new StreamReader(filename))
            {
                // Read each line until the end of the file
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    // Append each record to the overview with a tab
                    overview += Environment.NewLine + "\t" + record;
                }
            }
        }

        public static void HandleFriendsFile(string filename)
        {
            string overview = "", message;

            // Read the file and build the overview
            ReadFileExerciseOne(filename, ref overview);

            // Clear the console for new output
            Console.Clear();

            // Set message color based on whether the overview is empty
            Console.ForegroundColor = overview == "" ? ConsoleColor.Red : ConsoleColor.Green;

            // Set the appropriate message based on the overview content
            message = overview == "" ? "\n\tSorry that you have no circle of friends!" : $"\n\tMy circle of friends:\n {overview}";

            // Print the message
            Console.WriteLine(message);
        }
        #endregion

        #region Exercise 2
        public static void PrintTitleExerciseTwo(string teamName)
        {
            // Clear the console and print the title with asterisks underline
            Console.Clear();
            string title = $"Supporter scarf {teamName}";
            Console.WriteLine($"\n\t{title}");
            Console.WriteLine($"\t{new string('*', title.Length)}");
        }

        public static void PrintScarf(string symbol1, string symbol2, int length)
        {
            // Print the scarf pattern alternately with symbol1 and symbol2
            Console.WriteLine();

            for (int i = 1; i <= length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"\t{symbol1}");
                }
                else
                {
                    Console.Write($"\t{symbol2}");
                }

                Console.WriteLine();
            }
        }

        public static void HandleRecordExerciseTwo(string record)
        {
            // Split the record into fields: team name, symbol1, symbol2, length, and width
            string teamName, symbol1, symbol2;
            int length, width, position;

            // Extract the team name
            position = record.IndexOf(';');
            teamName = record.Substring(0, position); // teamname = "City Pirates"
            record = record.Substring(position + 1); // record = "b;g;6;3"

            // Extract the first symbol
            position = record.IndexOf(';');
            symbol1 = record.Substring(0, position); // symbol1 = "b"
            record = record.Substring(position + 1); // record = "g;6;3"

            // Extract the second symbol
            position = record.IndexOf(';');
            symbol2 = record.Substring(0, position); // symbol2 = "g"
            record = record.Substring(position + 1); // record = "6;3"

            // Extract the length
            position = record.IndexOf(';');
            length = int.Parse(record.Substring(0, position)); // length = 6
            record = record.Substring(position + 1); // record = "3"

            // Extract the width
            width = int.Parse(record); // width = 3

            // Print the title and scarf for the current record
            PrintTitleExerciseTwo(teamName);
            PrintScarf(new string(char.Parse(symbol1), width), new string(char.Parse(symbol2), width), length);
        }

        public static void HandleFileExerciseTwo(string filename)
        {
            // Check if the file exists
            if (File.Exists(filename))
            {
                bool empty = true;
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        empty = false;
                        string record = reader.ReadLine();
                        HandleRecordExerciseTwo(record);
                        PressEnter();
                    }
                }

                // Check if the file contained data
                if (empty)
                {
                    // Print notification if the file contains no data
                    PrintNotification($"{filename} does not contain data.");
                    PressEnter();
                }
            }
            else
            {
                // Print notification if the file does not exist
                PrintNotification($"{filename} does not exist!");
                PressEnter();
            }
        }
        #endregion

        #region Exercise 3
        public static void PrintTitleExerciseThree()
        {
            // Clear the console and print the title with an underline
            Console.Clear();
            string title = $"\tStudent list of {DateTime.Now.ToShortDateString()}";
            Console.WriteLine(title);
            Console.WriteLine($"\t{new string('=', title.Length)}\n");
        }

        public static void CapitalizeCertainLetters(ref string name, string symbol)
        {
            // Capitalize the first letter of the name
            name = name.Substring(0, 1).ToUpper() + name.Substring(1);

            // Capitalize each letter following the specified symbol
            int position = name.IndexOf(symbol);
            int startposition;

            while (position != -1)
            {
                name = name.Substring(0, position) + symbol + name.Substring(position + 1, 1).ToUpper() + name.Substring(position + 2);

                startposition = position + 1;

                position = name.IndexOf(symbol, startposition);
            }
        }

        public static void PrintStudentInfo(string number, string name, string firstName)
        {
            // Print the student information in the specified format
            Console.WriteLine($"\t{number.PadRight(10)}{firstName.PadRight(40)}{name}");
        }

        public static void HandleRecordExerciseThree(string record, ref bool isTitlePrinted)
        {
            // Split the record into fields: student number, last name, and first name
            string studentNumber, lastName, firstName, symbolLastName, symbolFirstName;
            int position = 8;

            studentNumber = record.Substring(0, position);
            record = record.Substring(position);

            position = record.IndexOf('*');
            lastName = record.Substring(0, position).Trim();
            firstName = record.Substring(position + 1).Trim();

            // Determine the symbol for capitalization
            symbolLastName = lastName.IndexOf('-') != -1 ? "-" : " ";
            symbolFirstName = firstName.IndexOf('-') != -1 ? "-" : " ";

            // Capitalize certain letters in the last name and first name
            CapitalizeCertainLetters(ref lastName, symbolLastName);
            CapitalizeCertainLetters(ref firstName, symbolFirstName);

            // Print the title if it hasn't been printed yet
            if (!isTitlePrinted)
            {
                PrintTitleExerciseThree();
                isTitlePrinted = true;
            }

            // Print the student information
            PrintStudentInfo(studentNumber, lastName, firstName);
        }

        public static void ReadFileExerciseThree(string filename)
        {
            bool titlePrinted = false;

            // Read the file and process each record
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    HandleRecordExerciseThree(record, ref titlePrinted);
                }
            }
        }

        public static void HandleStudents(string filename)
        {
            if (File.Exists(filename))
            {
                // Read and process the file if it exists
                ReadFileExerciseThree(filename);
            }
            else
            {
                // Print notification if the file does not exist
                PrintNotification($"{filename} does not exist!");
            }
        }
        #endregion

        #region Exercise 4
        public static string ComposeMenu(int numberOfItems)
        {
            // Compose the menu string with the specified number of items
            string menu = "0. Stop";

            for (int i = 1; i <= numberOfItems; i++)
            {
                menu += $"\n\t{i}. Poem {i}";
            }

            return menu;
        }

        public static void PrintTitleExerciseFour(string title)
        {
            // Clear the console and print the title with an underline
            Console.Clear();
            Console.WriteLine($"\n\t{title}");
            Console.WriteLine($"\t{new string('=', title.Length)}");
        }

        public static void PrintDetail(string information, bool newLine)
        {
            // Print the specified information with or without a newline
            if (newLine)
            {
                Console.WriteLine($"\t{information}");
            }
            else
            {
                Console.Write($"\t{information}");
            }
        }

        public static int ReadChoice(string menu, int numberOfChoices)
        {
            string input;
            int choice;

            do
            {
                do
                {
                    // Clear the console and print the menu
                    Console.Clear();
                    PrintTitleExerciseFour("Poems, a world of ...");
                    PrintDetail(menu, true);
                    Console.WriteLine();
                    PrintDetail("Make your choice: ", false);
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out choice));

            } while ((choice >= 0 && choice <= numberOfChoices) == false);

            return choice;
        }

        public static void HandleFileExerciseFour(string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                // Extract and format the title from the filename
                string title = file.Replace(".txt", "");
                title = title.Replace("doc/", "");
                title = title.Insert(4, " ");

                // Capitalize the first letter
                title = title.Substring(0, 1).ToUpper() + title.Substring(1);
                PrintTitleExerciseFour(title);

                // Read and print each line of the file
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    PrintDetail(record, true);
                }
            }
        }
        #endregion
    }
}
