using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes.Binding02
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("Am Class A");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA -> A: {A}");
        }
    }
}
