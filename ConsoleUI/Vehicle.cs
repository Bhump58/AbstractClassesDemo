using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int _year = 1990;
        public string _make = "Chevy";
        public string _model = "Equinox";
        public int Year { get; set; } = 1990;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "Equinox";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("The car is driving down the street");
        }




        /*
            * Create an abstract class called Vehicle-Done
            * The vehicle class shall have three string properties Year, Make, and Model-Done
            * Set the defaults to something generic in the Vehicle class - done
            * Vehicle shall have an abstract method called DriveAbstract with no implementation-Done
            * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-Done
            */
    }
}
