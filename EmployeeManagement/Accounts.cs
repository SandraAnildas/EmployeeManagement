using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Accounts : Employee
    {
        public override void ViewDetails()
        {
            Console.WriteLine("Accounts Details:");
            Console.WriteLine($"Employee No: {EmployeeNo}");
            Console.WriteLine($"Name: {Name}");
        }

        public override void ApplyForLeave()
        {
            Console.WriteLine("Accounts can apply for a maximum of 8 days of leave.");
        }
    }
}
