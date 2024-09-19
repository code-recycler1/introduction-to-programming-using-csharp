using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_exercises
{
    internal class Exercise_2
    {
        static void Main(string[] args)
        {
            // Adjust screen colors and set the title
            Methods.AdjustScreenColors("Exercise 2");

            // Handle the first supporters file (empty file scenario)
            Methods.HandleFileExerciseTwo(filename: "doc/supporters0.txt");

            // Handle the second supporters file (non-existent file scenario)
            Methods.HandleFileExerciseTwo(filename: "doc/supportersNone.txt");

            // Handle the third supporters file (with records)
            Methods.HandleFileExerciseTwo(filename: "doc/supporters.txt");
        }
    }
}
