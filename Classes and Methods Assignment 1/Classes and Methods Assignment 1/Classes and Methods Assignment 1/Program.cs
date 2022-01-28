using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        class Methods
        {
            public void Method1(int num)
            {
                int total1 = num / 10;
                Console.WriteLine(total1);
                return;
            }
            public int Method1(int num, out int num2)
            {
                num2 = 50;
                int total1 = num / 10;
                Console.WriteLine(total1);
                return total1;
            }
        }
        class program
        {
            static void Main()
            {
                Console.WriteLine("Please insert an integer to be divided by 5:");
                int num = Convert.ToInt32(Console.ReadLine());
                int num2;
                Methods n = new Methods();
                n.Method1(num);
                n.Method1(num, out num2);
                Console.WriteLine(num2);
                Console.ReadLine();
            }
        }
    }
