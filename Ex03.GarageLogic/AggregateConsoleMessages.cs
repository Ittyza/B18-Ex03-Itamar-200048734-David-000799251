using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    internal class AggregateConsoleMessages
    {
        internal static void vehicleHasNoWheels()
        {
            Console.WriteLine("The vehicle has no wheels.");
        }

        internal static void vehicleIsNotInTheGarage()
        {
            Console.WriteLine("There are no vehicles in the garage, try to add it before");
        }

        internal static void vehicleIsAlreadyInTheGarage(Vehicle i_Vehicle)
        {
            Console.WriteLine("Vehicle {0} is already in the garage, its status is {0}",i_Vehicle.LicenseNumber, i_Vehicle.EStatus);
        }

        internal static void displayDictionary(Dictionary<string, Vehicle> i_GarageVehicles)
        {
            if (i_GarageVehicles.Count != 0)
            {
                foreach (Vehicle vehicle in i_GarageVehicles.Values)
                {
                    Console.WriteLine("License number: {0} ", vehicle.LicenseNumber);
                }
            }
            else
            {
                vehicleIsNotInTheGarage();
            }
        }

        internal static void wrongFuel(string i_LicenseNumber)
        {
            Console.WriteLine("Wrong fuel for vehicle {0}, please add the right type. ",i_LicenseNumber);
        }

        internal static void theEngineOfTheVehicleisNotFillable(string i_LicenseNumber)
        {
            Console.WriteLine("The engine of the vehicle: {0} is not fillable, please talk with the creator",i_LicenseNumber);
        }

        internal static void displayVehicle(Dictionary<string,Vehicle> i_VehicleDictrionary)
        {
            foreach (Vehicle vehicle in i_VehicleDictrionary.Values)
            {
                Console.WriteLine("{0}",vehicle.ToString());
                
            //   , Fuel status + Fuel type / Battery status, other relevant information based on vehicle type);
            }
        }
    }
}