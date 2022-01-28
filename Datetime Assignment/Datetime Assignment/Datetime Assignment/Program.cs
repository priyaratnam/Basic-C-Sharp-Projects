using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);
            Console.WriteLine("Please enter a number that you want to enter: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time " + userNum + " exact hours from now is: " + dateTime.AddHours(userNum));
            Console.ReadLine();
        }
    }
}
