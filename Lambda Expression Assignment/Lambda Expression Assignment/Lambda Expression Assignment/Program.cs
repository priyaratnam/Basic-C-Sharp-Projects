using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    internal class Program
    {
        private static object thePriya;

        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            employees.Add(new Employees { FName = "Priya", LName = "Ratnam", Id = 8956 });
            employees.Add(new Employees { FName = "Mathu", LName = "Ratnam", Id = 7896 });
            employees.Add(new Employees { FName = "Chelvi", LName = "Aran", Id = 4563 });
            employees.Add(new Employees { FName = "Abishan", LName = "Aran", Id = 7894 });
            employees.Add(new Employees { FName = "Trishana", LName = "Aran", Id = 1258 });
            employees.Add(new Employees { FName = "Abishna", LName = "Aran", Id = 3645 });
            employees.Add(new Employees { FName = "Thuva", LName = "Moorthy", Id = 4856 });
            employees.Add(new Employees { FName = "Karan", LName = "Moorthy", Id = 4589 });
            employees.Add(new Employees { FName = "Rangan", LName = "Ratnam", Id = 1547 });
            employees.Add(new Employees { FName = "Ratnam", LName = "Thampi", Id = 6358 });
            foreach (Employees employee in employees)
            {
                if (employee.FName == "Priya")
                    thePriya.Add(employee);
            }
            List<Employees> thePriyaFNameLambda = employees.Where(x => x.FName.Contains("Priya")).ToList();
            List<Employees> thePriyaId = employees.Where(x => x.Id > 25).ToList();
        }
        class Employees
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int Id { get; set; }
        }
    }
}
