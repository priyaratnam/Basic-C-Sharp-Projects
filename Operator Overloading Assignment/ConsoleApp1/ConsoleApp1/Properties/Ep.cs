using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload_Assignment
{
    class Employee : Person, IQuittable
    {
        public int employee_ID { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Hello Everyone!, I am {0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("The entered employee is not in active");
            firstName = "";
            lastName = "";
        }
        public static bool operator ==(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
            {
                Console.WriteLine("Those IDs are similar");
                return true;
            }
            else
            {
                Console.WriteLine("Those IDs are not same.");
                return false;
            }
        }
        public static bool operator !=(Employee one, Employee two)
        {
            if (one.employeeID == two.employeeID)
            {
                Console.WriteLine("Those IDs are similar");
                return false;
            }
            else
            {
                Console.WriteLine("Those IDs are not same.");
                return true;
            }
        }
    }
}