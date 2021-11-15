using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Comparison_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("15");
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("20");
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            int salary = 15 * 40 * 52;
            Console.WriteLine(salary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            int salarys = 20 * 40 * 52;
            Console.WriteLine(salarys);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.ReadLine();
            bool trueorfalse = 31200 < 41600;
            Console.WriteLine(trueorfalse.ToString());
            Console.ReadLine();
     
        }

    }
}
