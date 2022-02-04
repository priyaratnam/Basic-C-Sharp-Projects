using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string COUNTRY = "Sri Lanka";
            Console.WriteLine($"Hello!! Welcome to {COUNTRY}\n Can you plaese answer the following thr questions to help us process your entry, Thank you:");
            Console.WriteLine("Are you travelling from inside the Canada?");
            var EU = Console.ReadLine().ToLower();
            if (EU == "yes" || EU == "yeah" || EU == "yup" || EU == "y")
            {
                Console.WriteLine("Can you please enter your first name: ");
                var fName = Console.ReadLine();
                Console.WriteLine("Can you please enter your last name: ");
                var lName = Console.ReadLine();
                Console.WriteLine($"How much money are you brining into {COUNTRY} in dollars:");
                decimal Money = Convert.ToDecimal(Console.ReadLine());
                Add traveller = new Add(fName, lName, Money);
                Console.WriteLine($"Thank you so much {traveller.fName} {traveller.lName} you are entering {COUNTRY} with {traveller.Money} dollars.\n" +
                    $"Please enjoy your visit.");
            }
            else if (EU == "no" || EU == "nope" || EU == "na" || EU == "n")
            {
                Console.WriteLine("Can you please enter your first name: ");
                var fName = Console.ReadLine();
                Console.WriteLine("Can you please enter your last name: ");
                var lName = Console.ReadLine();
                Add traveller = new Add(fName, lName);
                Console.WriteLine($"Thank you {traveller.fName} {traveller.lName} you are clear to enter ${COUNTRY}.\n" +
                    $"Please enjoy your visit this site.");
            }
            else Console.WriteLine("Please try again.");
        }
    }
}
