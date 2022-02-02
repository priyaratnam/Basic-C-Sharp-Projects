using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    public class mySampleClass
    {
        public mySampleClass()
        {
            Console.WriteLine("10");
        }
        public mySampleClass(int x) : this()
        {
            Console.WriteLine("Priya");
        }
        public mySampleClass(int x, string y) : this(50)
        {
            Console.WriteLine("9");
        }
    }
}