using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose a number that you like.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose a second number that you like.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please dividing ten...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            catch (FormatException ex)
            {
                Console.WriteLine("Enter your full number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't try to divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
