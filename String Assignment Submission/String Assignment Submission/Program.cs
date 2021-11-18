using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Priya";
            string quote = "The priya said, \"Hello\", Priya. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = @"C:\Users\Priya";

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");

            int length = name.Length;

            name = name.ToUpper();

            string names = "Priya";
            name = "Ratnem";

            StringBuilder sb = new StringBuilder("C#");
            sb.Append(", and");
            sb.Append(", .NET Framework");
            sb.AppendLine();
            sb.Append("Welcome to the course");
            Console.WriteLine(sb);

            StringBuilder sb1 = new StringBuilder("I learned lot of new things ");
            sb1.Insert(8, " from this course ");
            Console.WriteLine("Insert String: " + sb1);

            StringBuilder sb2 = new StringBuilder("I was submit previous assignements are:");
            sb2.Insert(39, " Basic C# Submission Assignement, Daily Report Assignement, Income Comparison Assignment, Loop Assignment, Math Operation Assignement and Repositories Setup.");
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder("So far I got my previous assignements are");
            sb3.Insert(41, "very well understanding and I will complete soon as possible.");
            Console.WriteLine(sb3);
            Console.ReadLine();

            Console.WriteLine(sb);
            Console.ReadLine();

        }


    }
}
