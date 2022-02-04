using System;
using System.Collections.Generic;
using System.Text;

namespace Additional_Features_Assignment
{
    class Add
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public decimal Money { get; set; }
        public Add(string fName, string lName, decimal Money)
        {
            this.fName = fName;
            this.lName = lName;
            this.Money = Money;
        }
        public Add(string fName, string lName) : this(fName, lName, 0)
        {
        }
    }
}