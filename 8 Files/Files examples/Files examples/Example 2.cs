using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_examples
{
    internal class Example_2
    {
        static void Main(string[] args)
        {
            string line, firstName, lastName;
            int position;

            // Open the file "example_2.txt" for reading
            using (StreamReader streamReader = new StreamReader("example_2.txt"))
            {
                // Read until the end of the file
                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine(); // Read a line from the file
                    position = line.IndexOf(';'); // Find the position of the semicolon

                    // Split the line into first name and last name
                    firstName = line.Substring(0, position);
                    lastName = line.Substring(position + 1);

                    // Print the names with padding
                    Console.WriteLine(firstName.PadRight(15) + lastName);
                    Console.WriteLine(firstName.PadLeft(15) + lastName.PadLeft(20));
                }
            }

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}
