using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Assignment
{
    public class EP : PS, IQS
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("I am Exit");
        }
    }
}