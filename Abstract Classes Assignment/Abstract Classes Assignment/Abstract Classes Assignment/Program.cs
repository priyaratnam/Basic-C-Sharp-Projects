using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "Kalaipriya";
            employee1.lastName = "Kanagaratnam";
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee1.sayName();
            Console.ReadLine();
        }
    }
}
