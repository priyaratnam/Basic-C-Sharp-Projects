using System;
using System.Collections.Generic;
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
            using (Stream_Writer file = new Stream_Writer(@"C:\Users\" true))
            {
                file.WriteLine(userNum);
            }
            string text = File.ReadAllText;
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
