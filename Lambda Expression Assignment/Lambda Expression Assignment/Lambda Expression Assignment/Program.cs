using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            List<string> firstnames = new List<string>()
            {
                "Priya", "Ratnam", "Mala", "Karan", "Thuva", "Abishna", "Abishan", "Trishana", "Aran", "Chelvi"
            };
            List<string> lastnames = new List<string>()
            {
                "Ratnam", "Ratnam", "Ratnam", "Ratnam", "Ratnam", "Ratnam", "Ratnam", "Ratnam", "Ratnam", "Ratnam"
            };
            List<int> IDs = new List<int>()
            {
                5, 8, 9, 10, 254, 145, 877, 658, 235, 546
            };
            List<int> indexes = new List<int>()
            {
               0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            foreach (int index in indexes)
            {
                Employee Employeeobject = new Employee();
                Employeeobject.firstname = firstnames[index];
                Employeeobject.lastname = lastnames[index];
                Employeeobject.ID = IDs[index];
                Employees.Add(Employeeobject);
            }
            foreach (Employee Employee in Employees)
            {
                Console.WriteLine(firstnames[1] + " " + lastnames[1] + " " + IDs[1]);

                Console.WriteLine(firstnames[4] + " " + lastnames[4] + " " + IDs[4]);
                break;
            }
            foreach (Employee employee in Employees.FindAll(i => i.firstname == "Priya"))
            {
                Console.WriteLine(employee.firstname + " " + employee.lastname + " " + employee.ID);
            }
            foreach (Employee employee in Employees.FindAll(a => a.ID >= 5))
            {
                Console.WriteLine(employee.firstname + " " + employee.lastname + " " + employee.ID);
            }
            Console.ReadLine();
        }
    }
}