using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    public class Employee<T>
    {
        public List<T> things { get; set; }
    }
}