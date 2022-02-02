using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee eName = new Employee
            {
                FirstName = "Priya",
                LastName = "Ratnam"
            };

            eName.SayName();
            Console.ReadLine();
        }
    }
}