using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02OOP.Classes
{
    internal class Car
    {
       
        public int Id { get; set; } // 4 Bytes
        public double Speed { get; set; } // 8 Bytes
        public string Model { get; set; } // 4 bytes For reference

        //public Car() { } 
        // CLR Generate PAramterless Constructor
        // Print Default Values

        // Constructor Overloading
        #region Constructor OverLoading
        //public Car(int id, double speed, string model)
        //{
        //    Id = id;
        //    Speed = speed;
        //    Model = model;
        //}

        //public Car(int id, double speed)
        //{
        //    Id = id;
        //    Speed = speed;
        //}

        //public Car(int id)
        //{
        //    Id = id;
        //}

        #endregion

        #region Constructor Chaining
        public Car(int id, double speed, string model)
        {
            Id = id;
            Speed = speed;
            Model = model;
        }

        public Car(int id, double speed) : this(id, speed, "BMW")
        {
        }

        public Car(int id) : this(id, 1000, "Tesla")
        {
        }
        #endregion

        public override string ToString()
        {
            return $"Id = {Id}, Speed = {Speed}, Model = {Model}";
        }
    }
}
