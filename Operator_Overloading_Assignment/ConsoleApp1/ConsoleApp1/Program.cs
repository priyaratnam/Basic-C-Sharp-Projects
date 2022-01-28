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
            Employee employee1 = new Employee();
            employee1.firstName = "Mala";
            employee1.lastName = "Ratnam";
            employee1.employeeID = 1236;
            Employee employee1 = new Employee();
            employee2.firstName = "Priya";
            employee2.lastName = "Ratnam";
            employee2.employeeID = 6547;
            Employee employee3 = new Employee();
            employee3.firstName = "Abishan";
            employee3.lastName = "Aran";
            employee3.employeeID = 9874;
            bool doesEqual = employee2 == employee3;
            Console.ReadLine();
        }
    }
}
