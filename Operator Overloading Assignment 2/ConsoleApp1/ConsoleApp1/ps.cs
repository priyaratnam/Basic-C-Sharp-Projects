using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload_Assignment
{
    public abstract class ps
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void Say_Name();
    }
}