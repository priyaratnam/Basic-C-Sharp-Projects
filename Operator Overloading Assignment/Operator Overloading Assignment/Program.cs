using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();
            example.FirstName = "Priya";
            example.LastName = "Ratnam";
            example.ID = 00000000;
            Employee example2 = new Employee();
            example2.FirstName = "Mala";
            example2.LastName = "Ratnam";
            example2.ID = 11111111;
            Console.WriteLine(example == example2);
            Console.ReadLine();
        }
    }
}