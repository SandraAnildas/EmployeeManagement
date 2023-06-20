using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Developer : Employee
    {
        public override void ViewDetails()
        {
            Console.WriteLine("Developer Details:");
            Console.WriteLine($"Employee No: {EmployeeNo}");
            Console.WriteLine($"Name: {Name}");
        }

        public override void ApplyForLeave()
        {
            Console.WriteLine("Developer can apply for a maximum of 12 days of leave.");
        }
    }
}
