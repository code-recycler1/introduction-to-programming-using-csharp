using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_examples
{
    internal class MethodWithReturnAndParams
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console does not print a euro symbol directly, this line sets the console’s output encoding to UTF-8
            Console.Title = "Method With Return And Params";

            // Declare variables
            string product;
            double priceExcludingVAT, priceIncludingVAT;
            int code;
            const double foodVAT = 6.0; // constant: a variable whose value cannot be changed in the program
            const double otherVAT = 21.0;

            // Read the input from the user
            Console.Write("Enter a product: ");
            product = Console.ReadLine();

            Console.Write("Enter the price excluding VAT: ");
            priceExcludingVAT = double.Parse(Console.ReadLine()); // It must be a double, otherwise, it will throw an error

            Console.WriteLine("Enter a VAT code: Code for food = 1, Code for other = 2");
            code = int.Parse(Console.ReadLine());

            // Calculate price including VAT
            if (code == 1)
            {
                priceIncludingVAT = Calculate(priceExcludingVAT, foodVAT);
            }
            else
            {
                priceIncludingVAT = Calculate(priceExcludingVAT, otherVAT);
            }

            // Output
            Console.WriteLine($"\nPrice including VAT = €{priceIncludingVAT}");
            // Or use a formatted output
            Console.WriteLine($"\nPrice including VAT = €{priceIncludingVAT:# ##0.00}");
            // # = suppresses leading zeros when the number is zero
            // .00 = shows 2 digits after the decimal point, even if they are zeros
            // # ##0.00 = adds a space between thousands and the rest


            // Wait for the user to press enter before closing the console
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        // Method to calculate the price including VAT
        private static double Calculate(double price, double vat) // Method with return and parameters
        {
            double vatAmount, result;

            vatAmount = price * vat / 100;
            result = price + vatAmount;

            return result;
        }
    }
}
