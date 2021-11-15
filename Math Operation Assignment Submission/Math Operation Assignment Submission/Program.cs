using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operation_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Takes an input from the user, multiplies it by 50, and prints the result to the console.");
            int num1 = 5;
            int num2 = 7;
            int product = num1 * num2;
            Console.WriteLine(product);

            Console.WriteLine("2. Takes an input from the user, adds 25 to it, and prints the result to the console.");
            int num3 = 5;
            int num4 = 7;
            int total = num3 + num4;
            Console.WriteLine(total);

            Console.WriteLine("3. Takes an input from the user, divides it by 12.5, and prints the result to the console.");
            int num5 = 5;
            int num6 = 7;
            int quotient = num5 / num6;
            Console.WriteLine(quotient);

            Console.WriteLine("4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.");
            Console.WriteLine(7.0 > 5.1);   
            Console.WriteLine(5.1 > 5.1);

            Console.WriteLine("5. Takes an input from the user, divides it by 12.5, and prints the result to the console.");
            int num9 = 5;
            int num10 = 7;
            int remainder = num9 % num10;
            Console.WriteLine(remainder);
        }
    }
}
