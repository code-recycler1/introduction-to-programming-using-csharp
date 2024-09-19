using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_exercises
{
    internal class Exercise_3
    {
        static void Main(string[] args)
        {
            // Adjust screen colors and set the title
            Methods.AdjustScreenColors("Exercise 3");

            // Handle the students file
            Methods.HandleStudents("doc/students.txt");

            // Prompt user to press enter
            Methods.PressEnter();
        }
    }
}
