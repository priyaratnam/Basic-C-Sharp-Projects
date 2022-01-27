using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ps
{
    internal class Pss
    {
        public abstract class Ps
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public abstract void sayName();
        }
    }
}
