using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Inheritance
{
    public class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int X , int Y)
        {
            this.X = X; 
            this.Y = Y; 
        }

        // Object Member Method
        public void Fun01()
        {
            Console.WriteLine("I Am Parent [base]");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"X: {X} :: Y: {Y}");
        }
        public override string ToString()
        {
            return $"X: {X} :: Y: {Y}";
        }
    }
}
