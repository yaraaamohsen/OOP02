using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Inheritance
{
    // Once i Add ': Parent' There Is Error Appear Due To The Paramterless Constructor Of Child Class Chaining on Parent
    // And There Is No Paramterless Constructor In Parent Class
    public class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z): base(x, y)
        {
            // Parent Will Excute First Then Child
            this.Z = Z;
        }

        public override string ToString()
        {
            return $"X: {X} :: Y: {Y} :: Z: {Z}";
        }

        // Override Using New keyword -> Masking
        // Override With New -> Static Binding [Early Binding]
        // Compilation Time
        // Compiler Will Bind Method Call Based On Reference Type Not Object Type
        // 
        public new void Fun01() // Masking
        {
            Console.WriteLine("I Am Child");
        }

        // override Using Override Keyword -> public - Virtual
        // override Using Override Keyword -> Dynamic Binding [Late Binding]
        // Runtime
        // CLR Will Bind Method Call Based On Object Not Reference Type 

        public override void Fun02()
        {
            base.Fun02();
            Console.WriteLine($"Parent: X : {X}, Y : {Y}, Z : {Z}");
        }
    }
}
