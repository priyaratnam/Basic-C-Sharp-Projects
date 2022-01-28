using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<int> employeesNum = new Employee<int>();
            Employee<string> employees = new Employee<string>();
            employees.things = new List<string>() { "Abishna", "Trishana", "Abishan", "Priya" };
            foreach (string employee in employees.things)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
            employeesNum.things = new List<int>() { 8, 24, 37, 41 };
            foreach (int employee in employeesNum.things)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
    }
}
