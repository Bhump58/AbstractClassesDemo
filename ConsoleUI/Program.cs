using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            var vehicles = new List<Vehicle>();

            var myCar = new Car();

            var myMotorcycle = new Motorcycle();

            Vehicle newCar = new Car();

            Vehicle newMoto = new Motorcycle();

            myCar.HasFourWheels = true;
            myCar.HasTrunk = true;

            myMotorcycle.HasSideCar = false;
            myMotorcycle.IsACruiser = true;

            newCar.Make = "Ford";
            newCar.Model = "Mustang";
            newCar.Year = 2012;

            newMoto.DriveAbstract();


            vehicles.Add(myCar);
            vehicles.Add(myMotorcycle);
            vehicles.Add(newCar);
            vehicles.Add(newMoto);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Make);
                Console.WriteLine(vehicle.Model);
                Console.WriteLine(vehicle.Year);
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("********************");
            }

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, 
             * and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes -Done
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
