using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class Grade
    {
        public int Grade_Ids { get; set; }
        public string Grade_Names { get; set; }
        public string Section { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}