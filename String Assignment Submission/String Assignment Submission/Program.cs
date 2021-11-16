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

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Priya");

            Console.WriteLine(sb);
            Console.ReadLine();

        }


    }
}
