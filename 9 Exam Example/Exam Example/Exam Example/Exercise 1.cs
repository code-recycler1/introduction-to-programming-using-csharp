using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Example
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            // Adjust screen colors and set the title
            Methods.AdjustScreenColors("Exercise 1");

            // Print table header
            Methods.PrintHeader();

            // Handle the consumption file
            Methods.HandleFileExerciseOne("./doc/Consumption.txt");

            // Prompt user to press enter
            Methods.PressEnter();
        }
    }
}
