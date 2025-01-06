using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes
{
    internal class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public double HourRate { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm PartTime Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"PartTimeEmployee ->Id : {Id}, Name : {Name}, Age : {Age}, CountOfHours : {CountOfHours}, HourRate : {HourRate}");

        }
    }
}
