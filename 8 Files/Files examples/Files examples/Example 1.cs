using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_examples
{
    internal class Example_1
    {
        static void Main(string[] args)
        {
            string name;

            // Open the file "example_1.txt" for reading
            using (StreamReader streamReader = new StreamReader("example_1.txt"))
            {
                // Read until the end of the file
                while (!streamReader.EndOfStream)
                {
                    name = streamReader.ReadLine(); // Read a line from the file
                    Console.WriteLine(name); // Print the line to the console
                }
            }

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}
