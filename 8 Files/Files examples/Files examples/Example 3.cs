using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_examples
{
    internal class Example_3
    {
        static void Main(string[] args)
        {
            string firstName, line, output;
            double height, weight;
            int position;

            string file = "example_3-1.txt";

            if (File.Exists(file))
            {
                // Create a header for the output
                output = "First Name".PadRight(20) + "Weight".PadRight(10) + "Height" + Environment.NewLine;

                // Open the file "example_3.txt" for reading
                using (StreamReader reader = new StreamReader(file))
                {
                    // Read until the end of the file
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine(); // Read a line from the file
                        position = line.IndexOf(';'); // Find the position of the first semicolon
                        firstName = line.Substring(0, position); // Extract the first name
                        line = line.Substring(position + 1); // Remove the first name from the line
                        position = line.IndexOf(';'); // Find the position of the second semicolon
                        height = double.Parse(line.Substring(0, position)); // Extract and parse the height
                        weight = double.Parse(line.Substring(position + 1)); // Extract and parse the weight
                                                                             // Add the data to the output string
                        output += firstName.PadRight(20) + weight.ToString().PadRight(10) + height + "\n";
                    }
                }

                Console.Write(output); // Print the output string

            }
            else
            {
                Console.WriteLine("The file does not exist."); // Print an error message if the file does not exist
            }

            Console.ReadLine(); // Wait for user input before closing
        }

    }
}
