using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 15, speed = 3;
            bool DUI = true;
            Console.WriteLine(" A basic approval program for car insurance.");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI?");
            DUI = Convert.ToBoolean(Console.ReadLine());
         
            Console.WriteLine("How many speeding tickets do you have?");
            speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && !DUI && speed <= 3);
            Console.ReadLine();





        }
    }
}
