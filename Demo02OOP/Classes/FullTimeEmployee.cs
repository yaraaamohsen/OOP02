using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes
{
    internal class FullTimeEmployee : Employee
    {
        public double Salary { get; set; }
        public FullTimeEmployee(int id, string name, int age, double salary) : base(id, name, age)
        {
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm FullTime Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"FullTimeEmployee ->Id : {Id}, Name : {Name}, Age : {Age}, Salary : {Salary}");

        }

    }
}
