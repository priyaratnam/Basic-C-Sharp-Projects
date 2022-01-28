using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School_Context())
            {
                var stud = new Student() { Student_Name = "Priya" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.Write("Student Names are saved successfully in the File!");
                Console.ReadLine();
            }
        }
    }
}
