using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes.Binding02
{
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        public new void MyFun01()
        {
            Console.WriteLine("Am Class B");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeB -> A: {A}, B: {B}");
        }

    }
}
