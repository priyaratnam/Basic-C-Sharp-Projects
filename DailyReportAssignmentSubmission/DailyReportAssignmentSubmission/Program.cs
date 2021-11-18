using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignmentSubmission
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            {
                Console.WriteLine("What course are you in?");
                string course = Console.ReadLine();
                Console.WriteLine("Your course is: " + course);
            }
            {
                Console.WriteLine("What page number?");
                int page = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The page number is: " + page);
            }
            {
                Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
                bool res  = Convert.ToBoolean(Console.ReadLine());
                bool a = true;
                bool b = false;
                Console.WriteLine("Return Value = " + res);
                Console.WriteLine("Return Value = " + res);
            }
            {
                string text = ("Were there any positive experiences you’d like to share? Please give specifics.");
                string any = "Convert.ToInt32(Console.ReadLine())";
                Console.WriteLine("The positive experiences are: " + any);
            }
            {
                string text = ("Is there any other feedback you’d like to provide? Please be specific.");
                string feedback = "Convert.ToInt32(Console.ReadLine())";
                Console.WriteLine("The feedback is: " + feedback);
            }
            {
                Console.WriteLine("How many hours did you study today?");
                int hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The total hours is: " + hour);
            }
           
                Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
                Console.ReadLine();
          
         }
    }
}
    
