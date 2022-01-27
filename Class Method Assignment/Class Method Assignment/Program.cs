using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int returnMult;
            Math_up myNumObj = new Math_up();
            Console.WriteLine("Input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            myNumObj.myMethodOp(userNum);
            int myNum = 100;
            Console.WriteLine("What is your number plus add the my number: " + Math_up.myMethodOp(userNum, myNum));
            myNumObj.MethodOut(userNum, out int extraNum);
            Console.WriteLine("What you get the number plus hundread is: " + extraNum);
            returnMult = Static_Math_up.MethodMult(userNum);
            Console.WriteLine("The final total number times twenty is: " + returnMult);
            Console.ReadLine();
        }
    }
}