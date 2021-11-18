using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int package;
            int width;
            int height;
            int weight;
            int length;

            Console.WriteLine("Welcome to Package Express");
            Console.ReadLine();

            Console.Write("Please enter the package weight:");
            weight = Convert.ToInt32(Console.ReadLine());
            bool trueorfalse = weight > 50;
            Console.WriteLine(trueorfalse.ToString());

            Console.Write("Please enterthe package width: ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enterthe package height: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enterthe package length: ");
            length = Convert.ToInt32(Console.ReadLine());

            package = (height + width + weight + length);


            Console.WriteLine("Your estimated total for shipping this package is:");
            package = ((height * width * length) * weight / 100);
            Console.WriteLine(package);
            Console.ReadLine();

            Console.WriteLine("Thank you");
            Console.ReadLine();

        }
    }
}

