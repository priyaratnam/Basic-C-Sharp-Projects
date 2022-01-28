using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give you a any number. Any number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\",true))
            {
                file.WriteLine(userNum);
            }
            string text = File.ReadAllText(@"C:\Users\");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
