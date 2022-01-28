using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the number 78:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please insert the number 36:");
            double y = Convert.ToDouble(Console.ReadLine());
            void method1(double var1, double var2)
            {
                var1 = 22 + var2 + var1;
                Console.WriteLine(var2);
            }
            method1(var1: x, var2: y);
            Console.ReadLine();
        }
    }
}
