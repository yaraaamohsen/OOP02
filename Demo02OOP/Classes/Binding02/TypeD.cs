using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes.Binding02
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }
        public new void MyFun01()
        {
            Console.WriteLine("Am Class D");
        }

        // new      -> When I Use New keyword With Virtual, It Makes It End Of Sequence
        // virtual  -> Start For New Sequence
        public new virtual void MyFun02() // End Of Sequence
        {
            Console.WriteLine($"TypeD -> A: {A}, B: {B}, C: {C}, D: {D}");

        }
    }
}
