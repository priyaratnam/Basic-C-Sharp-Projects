using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Student_Context())
            {
            Console.WriteLine("What is your name please?");
            var student_Name = Console.ReadLine();
            var nStudent = new Student { student_Name = student_Name };
            db.Students.Add(nStudent);
            db.SaveChanges();
        }
    }
}
public class Student
{
    public int Student_Id { get; set; }
    public string student_Name { get; set; }
    public virtual Lazy<Student> Students { get; set; }
}
public class Student_Context : Db_Context
{
    public Db_Set<Student> Students { get; set; }
}
    }


