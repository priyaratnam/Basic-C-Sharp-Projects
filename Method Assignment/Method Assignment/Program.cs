using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number which I will do some Math operations on.");
            string line = Console.ReadLine();
            Data = Int32.Parse(line);
            var operatorObject = new Operator();
            var result = operatorObject.GetAdd(Data);
            Console.WriteLine("\n" + Data + " + 2 = " + result);
            Console.ReadLine();
            var operatorObject2 = new Operator();
            var result2 = operatorObject2.GetSubtract(result);
            Console.WriteLine(result + " - 2 = " + result2);
            Console.ReadLine();
            var operatorObject3 = new Operator();
            var result3 = operatorObject3.GetDivide(result2);
            Console.WriteLine(result2 + " / 5 = " + result3);
            Console.ReadLine();
        }
    }
}