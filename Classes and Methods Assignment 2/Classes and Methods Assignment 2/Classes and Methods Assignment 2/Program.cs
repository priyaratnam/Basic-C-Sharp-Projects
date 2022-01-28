using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    internal class Program
    {
            class Methods
        {
            public int Method1(int var)
            {
                int total1 = var + 24;
                return total1;
            }
            public int Deci(decimal var2)
            {
                var2 = var2 + 24;
                int total2 = Convert.ToInt32(var2);
                return total2;
            }
            public int Strin(string var3)
            {
                try
                {
                    int total3 = Convert.ToInt32(var3) + 24;
                    return total3;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        class program
        {
            static void Main()
            {
                Console.WriteLine("Please insert an integer to be added by 24, divided by 5, and multiplied by 50:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please insert a decimal to be converted to interger: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please insert an integer:");
                string var3 = Console.ReadLine();
                Methods n = new Methods();
                int total1 = n.Method1(num);
                Console.WriteLine(total1);
                int total2 = Convert.ToInt32(n.Deci(num2));
                Console.WriteLine(total2);
                int total3 = n.Strin(var3);
                Console.WriteLine(total3);
                Console.ReadLine();
            }
        }
}
