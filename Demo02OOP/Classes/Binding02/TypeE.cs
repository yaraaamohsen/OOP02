using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes.Binding02
{
    internal class TypeE : TypeD
    {
        

        public int E { get; set; }
        public TypeE(int a, int b, int c, int d,int e): base(a, b, c, d)
        {
            E = e;
        }

        public new void MyFun01()
        {
            Console.WriteLine("Am Class E");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"TypeE -> A: {A}, B: {B}, C: {C}, D: {D}, E: {E}");

        }
    }
}
