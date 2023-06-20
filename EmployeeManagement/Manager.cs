using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Manager : Employee
    {
        public override void ViewDetails()
        {
            Console.WriteLine("Manager Details:");
            Console.WriteLine($"Employee No: {EmployeeNo}");
            Console.WriteLine($"Name: {Name}");
        }

        public override void ApplyForLeave()
        {
            Console.WriteLine("Manager can apply for a maximum of 10 days of leave.");
        }
    }
}
