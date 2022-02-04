using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Assignment
{
    public class PS
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine($"Your name is {fName} {lName}");
        }
    }
}