using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class MathOp
    {
        public void myMethodOp(int userNum)
        {
            Console.WriteLine("Please divide your number by ten: " + (userNum / 10));
        }
        public static int myMethod_up(int userNum, int myNum)
        {
            int newNum = userNum + myNum;
            return newNum;
        }
        public void Method_out(int userNum, out int extraNum)
        {
            extraNum = userNum + 100;
        }
    }
}