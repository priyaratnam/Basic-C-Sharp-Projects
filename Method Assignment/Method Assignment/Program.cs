using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee() { Id = 1, name = "Movie1" };
            Employee b = new Employee() { Id = 1, name = "Movie2" };
            Console.WriteLine(a.Id == b.Id);
        }
    }
}
