using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class Student
    {
        public int Student_IDs { get; set; }
        public string Student_Names { get; set; }
        public DateTime? Date_Of_Births { get; set; }
        public byte[] Photos { get; set; }
        public decimal Heights { get; set; }
        public float Weights { get; set; }

        public Grade Grades { get; set; }
    }
}