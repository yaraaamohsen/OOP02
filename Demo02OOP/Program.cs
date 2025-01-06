using Demo02OOP.Classes;
using Demo02OOP.Classes.Binding02;
using Demo02OOP.Inheritance;

namespace Demo02OOP
{

    // 1. Class
    // Default Access Modifiers For THe Class
        // 1. Internal [Default]
        // 2. Public
    // What I Can Write Inside It
        // 1.1. Attributes [Variables]
        // 1.2. Functions [Constructors - SetterGetter - Methods]
        // 1.3. Prperties [Full property - Automtic property - Indexer]
        // 1.4. Events
    // Access Modifiers Allowed To Write Inside The Class
        // 1. private [default]
        // 2. Private Protected
        // 3. Protected
        // 4. Internal
        // 5. Protected Internal
        // 6. public

    // 2. Struct
    // 3. Interface
    // 4. Enum

    
    internal class Program
    {
        static void ProcessEmployee(Employee employee)
        {
            if (employee is not null)
            {
                employee.GetEmployeeType();
                employee.GetEmployeeData();
            }
        }
       
        static void Main(string[] args)
        {
            #region Revision
            // 1. Struct : Valuetype : STACK
            // We Use "New" Keyword To Generate Constructor
            // Constructor Has Not Return Type
            // CLR Will Generate Paramterless Constructor

            // 4 Pillars For OOP :
            //      1. Encapsulation
            //      2. Inheritance
            //      3. Polymerphism
            //      4. Abstraction


            // Class : Reference Type : HEAP 
            #endregion

            #region Class
            //Car C1;
            // Declare Reference From Type 'Car'
            // Reference Can Refer To An Object From Type 'Car' Or Any Object From Class Inherite From Type 'Car'
            // CLR Will Allocate 4 Bytes In Stack
            // 0 Byte Will Allocate In Heap

            //C1 = new Car();
            // New
            // 1. Allocate Required Bytes In Heap [ 16 Bytes ] 4 For Id, * For Speed, 4 For Reference Of String
            // 2. Intialize Allocated Bytes With THier Default Value
            // 3. Call User Defined Constructor
            // 4. Assign The Reference To Allocated Object

            //Console.WriteLine(C1);

            #endregion

            #region Inheritance
            //// 1. Inheritance
            //Parent parent = new Parent(1, 2);
            ////Console.WriteLine(parent);
            //parent.Fun01();
            //parent.Fun02();

            //Child child = new Child(1, 2, 3); 
            #endregion

            #region Polymorphism
            // Overloading : Methods - Constructor - Indexer (Action Will Change)
            //      There Are More Than One Function (In The Same Scope[Class - Struct])
            //      THese Have The Same Name But With Different Signature
            //      By Changing Number Of Parameter
            //      By Changing Types Of Parameter
            //      By Changing Order Of Parameter

            // Overridding : Must Be Used In Inherietance Relationship [Class]

            //Parent parent = new Parent(3,2);
            //parent.Fun01();

            //parent.Fun02();
            //Child child = new Child(3,2,5);
            //child.Fun01();
            //child.Fun02();



            #endregion

            #region Binding
            // Reference From Parent --> Object From Child

            //Parent refBase;
            //// Create Reference From Parent
            //// In Stack [4 Bytes]
            //// Refer TO Null
            //refBase = new Child(3, 4, 5);
            //refBase.X = 1;      // Valid
            //refBase.Fun01();    // Valid [new]
            //refBase.Fun02();    // Valid [Override]
            //refBase.Z = 4;      // Invalid
            #endregion

            #region Not Binding
            // Reference From Child  --> Object From Parent
            // Child child = (Child)new Parent(4,5); // Explicit Casting [Unsafe]
            //Parent parent = new Child(4, 5, 6); // reeference From PArent To Object Of Child [Binding] 
            //Child child01 = (Child)parent; // Valid [Assign Object From Child TO Reference From Child]

            #endregion

            #region Binding Ex01
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, "Mariam", 30, 5000);
            //ProcessEmployee(fullTimeEmployee);

            //// As I Don't Have Constructor( TO Put Data On It )
            ////PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            ////partTimeEmployee.Id = 1;
            ////partTimeEmployee.Name = "Yara";
            ////partTimeEmployee.Age = 25;
            ////partTimeEmployee.CountOfHours = 15;
            ////partTimeEmployee.HourRate = 50;

            //// Object Intializer .NET 6.0 Feature
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Yara",
            //    Age = 25,
            //    HourRate = 50,
            //    CountOfHours = 15
            //};
            //ProcessEmployee(partTimeEmployee);


            #endregion

            #region Binding Ex02
            //TypeB typeB = new TypeC(4, 5, 6); // Type B Is Direct Parent Of TypeC
            //typeB.MyFun01(); // Am Type B [Static Binding, Method Call Based On Reference Type (TypeB)]
            //typeB.MyFun02(); // Type C [Dynamic Binding, Method Call Based On Object Type]

            ////typeB.A = 10;
            ////typeB.B = 20;
            ////// typeB.C = 30; // Invalid

            //TypeA typeA = new TypeC(7, 8, 9); // TypeC is Indirect Parent For TypeA 
            //typeA.MyFun01();// Am Type A [Static Binding, Method Call Based On Reference Type (TypeA)]
            //typeA.MyFun02();// Type C [Dynamic Binding, Method Call Based On Object Type]
            //typeA.A = 20;
            ////typeA.B = 30; // Invalid
            ////typeA.C = 40; // Invalid
            ///
            TypeA typeA = new TypeE(1,2,3,4,5);
            TypeB typeB = new TypeE(1,2,3,4,5);
            TypeC typeC = new TypeE(1,2,3,4,5);    

            typeA.MyFun01();
            typeA.MyFun02(); // Last Override occur On This Function Is On TypeC
            Console.WriteLine("===================");
            typeB.MyFun01();
            typeB.MyFun02();
            Console.WriteLine("===================");
            typeC.MyFun01();
            typeC.MyFun02();


            #endregion

        }
    }
}
