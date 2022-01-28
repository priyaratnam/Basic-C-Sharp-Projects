using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class School_Context : Db_Context
    {
        public School_Context() : base()
        {

        }
        public Db_Set<Student> Students { get; set; }
        public Db_Set<Grade> Grades { get; set; }
    }
}