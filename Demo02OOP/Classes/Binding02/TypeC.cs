using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes.Binding02
{
    // TypeC : Direct Parent [TypeB]
    // TypeC : Indirect Parent [TypeA]
    public class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }

        public new void MyFun01()
        {
            Console.WriteLine("Am Class C");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"TypeC -> A: {A}, B: {B}, C: {C}");

        }
    }
}
