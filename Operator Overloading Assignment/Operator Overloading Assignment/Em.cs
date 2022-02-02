using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    class Em : Ps
    {
        public int ID { get; set; }
        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return false;
        }
        public override bool Equals(object obj)
        {
            var item = obj as Employee;

            if (item == null)
            {
                return false;
            }
            return this.ID.Equals(item.ID);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
