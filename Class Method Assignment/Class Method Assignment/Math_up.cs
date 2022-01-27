using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class Math_up
    {
        public void myMethodOp(int userNum)
        {
            Console.WriteLine("Your number divided by hundread is: " + (userNum / 100));
        }
        public static int myMethod_op(int userNum, int myNum)
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