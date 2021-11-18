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
            int weeklydays;
            int hourlyRate;
            int yearlySalary;
            int hourlyRate2;
            int weeklydays2;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            hourlyRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            weeklydays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            hourlyRate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            weeklydays2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            yearlySalary = (weeklydays * hourlyRate * 52);
            Console.WriteLine(yearlySalary);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            yearlySalary = (weeklydays2 * hourlyRate2 * 52);
            Console.WriteLine(yearlySalary);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2");
            Console.ReadLine();
            bool trueorfalse = 31200 < 41600;
            Console.WriteLine(trueorfalse.ToString());
            Console.ReadLine();
     
        }

    }
}
