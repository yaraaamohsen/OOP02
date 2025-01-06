using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Employee()
        {
            
        }
        public void GetEmployeeType()
        {
            Console.WriteLine("I'm Employee");
        }
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Employee ->Id : {Id}, Name : {Name}, Age : {Age}");
        }
    }
}
