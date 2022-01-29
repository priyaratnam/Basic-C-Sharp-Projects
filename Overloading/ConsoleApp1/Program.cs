using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee2 = new Employee();
            employee2.firstName = "Priya";
            employee2.lastName = "Ratnam";
            employee2.employeeID = 1997;
            Employee employee3 = new Employee();
            employee3.firstName = "Mala";
            employee3.lastName = "Ratnam";
            employee3.employeeID = 1957;
            bool doesEqual = employee2 == employee3; 
            Console.ReadLine();
        }
    }
}
