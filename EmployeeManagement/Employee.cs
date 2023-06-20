using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public abstract class Employee
    {
        public int EmployeeNo { get; set; }
        public string Name { get; set; }
        public abstract void ViewDetails();
        public abstract void ApplyForLeave();
    }
}
