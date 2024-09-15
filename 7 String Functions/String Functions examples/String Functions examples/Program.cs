using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Substring methods
            PrintTitle("Example 1: Substring methods");

            string sentence = "carpe diem";
            Console.WriteLine($"Senctence: {sentence}");

            // Substring(int start, int count)
            Console.WriteLine($"Piece: >{sentence.Substring(0, 2)}<"); // Output: >ca<
            Console.WriteLine($"Piece: >{sentence.Substring(3, 5)}<"); // Output: >e diem<

            // Substring(int start)
            Console.WriteLine($"Piece: >{sentence.Substring(0)}<"); // Output: >carpe diem<
            Console.WriteLine($"Piece: >{sentence.Substring(3)}<"); // Output: >e diem<
            Console.WriteLine($"Piece: >{sentence.Substring(8)}<"); // Output: >diem<

            Console.WriteLine();

            // Example 2: Insert method
            PrintTitle("Example 2: Insert method");

            string addition = "LASER";
            Console.WriteLine($"Addition: {addition}");
            Console.WriteLine($"Extra: >{sentence.Insert(0, addition)}<"); // Output: >LASERcarpe diem<
            Console.WriteLine($"Extra: >{sentence.Insert(5, addition)}<"); // Output: >carpeLASER diem<
            Console.WriteLine($"Extra: >{sentence.Insert(sentence.Length, addition)}<"); // Output: >carpe diemLASER<

            Console.WriteLine();

            // Example 3: Replace method
            PrintTitle("Example 3: Replace method");

            Console.WriteLine($"Change: >{sentence.Replace("carpe", "Seize the")}<"); // Output: >Seize the diem<
            Console.WriteLine($"Change: >{sentence.Replace("e", "u")}<"); // Output: >carpu dium<

            Console.WriteLine();

            // Example 4: Trim methods
            PrintTitle("Example 4: Trim methods");

            sentence = "     carpe     diem     ";
            Console.WriteLine($"Senctence: {sentence}");
            Console.WriteLine($"Trim: >{sentence.Trim()}<"); // Output: >carpe diem<
            Console.WriteLine($"TrimStart: >{sentence.TrimStart()}<"); // Output: >carpe diem     <
            Console.WriteLine($"TrimEnd: >{sentence.TrimEnd()}<"); // Output: >     carpe diem<

            Console.WriteLine();

            // Example 5: Pad methods
            PrintTitle("Example 5: Pad methods");

            sentence = "carpe diem";
            Console.WriteLine($"Senctence: {sentence}");
            Console.WriteLine($"PadLeft: >{sentence.PadLeft(20)}<"); // Output: >         carpe diem<
            Console.WriteLine($"PadRight: >{sentence.PadRight(20)}<"); // Output: >carpe diem         <

            Console.WriteLine();

            // Example 6: Pad with custom character
            PrintTitle("Example 6: Pad with custom character");

            Console.WriteLine($"PadLeft with '.': >{sentence.PadLeft(20, '.')}<"); // Output: >...........carpe diem<
            Console.WriteLine($"PadRight with '.': >{sentence.PadRight(20, '.')}<"); // Output: >carpe diem...........<

            Console.WriteLine();

            // Example 7: IndexOf methods
            PrintTitle("Example 7: IndexOf methods");

            Console.WriteLine($"IndexOf 'rp': >{sentence.IndexOf("rp")}<"); // Output: >1<
            Console.WriteLine($"IndexOf 'die': >{sentence.IndexOf("die")}<"); // Output: >9<

            Console.WriteLine();

            // Example 8: IndexOf with start index
            PrintTitle("Example 8: IndexOf with start index");

            Console.WriteLine($"IndexOf 'e' starting from 0: >{sentence.IndexOf("e", 0)}<"); // Output: >2<
            Console.WriteLine($"IndexOf 'e' starting from 5: >{sentence.IndexOf("e", 5)}<"); // Output: >9<

            Console.WriteLine();

            // Example 9: LastIndexOf methods
            PrintTitle("Example 9: LastIndexOf methods");
    
            sentence = "apple, tree. Tree of apples.";
            Console.WriteLine($"Senctence: {sentence}");
            Console.WriteLine($"First occurrence of 'apple': >{sentence.IndexOf("apple")}<"); // Output: >0<
            Console.WriteLine($"Last occurrence of 'apple': >{sentence.LastIndexOf("apple")}<"); // Output: >19<

            Console.WriteLine();

            // Example 10: Custom Replace method
            PrintTitle("Example 10: Custom Replace method");

            sentence = "My name is Bob. I am not smart.";
            Console.WriteLine($"Senctence: {sentence}");
            string newSentence = Replace(sentence, "Bob", "Jane");
            newSentence = Replace(newSentence, "not ", "super ");
            Console.WriteLine($"New sentence: {newSentence}"); // Output: >My name is Jane. I am super smart.<

            // Wait for user to press Enter before closing
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        // Custom Replace implementation
        private static string Replace(string original, string oldValue, string newValue)
        {
            string part1, part2;
            int index;

            index = original.IndexOf(oldValue);
            part1 = original.Substring(0, index);
            part2 = original.Substring(index + oldValue.Length);

            return part1 + newValue + part2;
        }

        private static void PrintTitle(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine(new string('-', title.Length));
        }
    }
}
