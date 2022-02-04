using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        static void Main()
        {
            EP Sample = new EP();
            Sample.fName = "Priya";
            Sample.lName = "Ratnam";
            Sample.SayName();
            IQS Iquit = new EP();
            Iquit.Quit();
        }
    }
}
