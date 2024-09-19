using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_exercises
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            // Adjust screen colors and set the title
            Methods.AdjustScreenColors("Exercise 1");

            // Handle the first friends file (empty file scenario)
            Methods.HandleFriendsFile(filename: "doc/friends0.txt");

            // Prompt user to press enter
            Methods.PressEnter();

            // Handle the second friends file (with records)
            Methods.HandleFriendsFile(filename: "doc/friends.txt");

            // Prompt user to press enter
            Methods.PressEnter();
        }
    }
}
