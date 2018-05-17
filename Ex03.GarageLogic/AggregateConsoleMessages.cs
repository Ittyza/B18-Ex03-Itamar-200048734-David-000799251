using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public class AggregateConsoleMessages
    {
        public static void MainMenu(Garage i_Garage)
        {
            Console.WriteLine(
@"Welcome to {0}'s Main Menu

What action would you like to implement?

1. Insert new vehicle
2. Display the vehicles currently in the garage
3. Change a certain vehichle's status
4. Inflate tyres of vehicle
5. Refuel a vehicle
6. Charge a vehicle
7. Display vehicle information

0. Quit",
i_Garage.GarageName);
        }

        internal static void vehicleHasNoWheels()
        {
            Console.WriteLine("The vehicle has no wheels.");
        }

        internal static void vehicleIsNotInTheGarage()
        {
            Console.WriteLine("There are no vehicles in the garage, try to add it before");
        }

        internal static void licenseIsNotInTheGarage()
        {
            Console.WriteLine("There are no vehicles with that license in the garage.");
        }

        internal static void vehicleIsAlreadyInTheGarage(Vehicle i_Vehicle)
        {
            Console.WriteLine(
                "Vehicle {0} is already in the garage, its status is {0}",
                i_Vehicle.LicenseNumber,
                i_Vehicle.EStatus);
        }

        internal static void displayDictionary(Dictionary<string, Vehicle> i_GarageVehicles)
        {
            if (i_GarageVehicles.Count != 0)
            {
                foreach (Vehicle vehicle in i_GarageVehicles.Values)
                {
                    Console.WriteLine(
                        "License number: {0} and his status is {1} ",
                        vehicle.LicenseNumber,
                        vehicle.EStatus.ToString());
                }
            }
            else
            {
                vehicleIsNotInTheGarage();
            }
        }

        internal static void wrongFuel(string i_LicenseNumber)
        {
            Console.WriteLine(
                "Wrong fuel for vehicle {0}, please add the right type. ", 
                i_LicenseNumber);
        }

        internal static void theEngineOfTheVehicleisNotFillable(string i_LicenseNumber)
        {
            Console.WriteLine(
                "The engine of the vehicle: {0} is not fillable, please talk with the creator", 
                i_LicenseNumber);
        }

        internal static void displayVehicle(Dictionary<string, Vehicle> i_VehicleDictrionary)
        {
            string stringToPrint = string.Empty;
            if (i_VehicleDictrionary.Count > 0)
            {
                foreach (Vehicle vehicle in i_VehicleDictrionary.Values)
                {
                    stringToPrint += string.Format("{0}, {1}", vehicle.ToString(), vehicle.Wheels[0].ToString());
                    if (vehicle.EnergyType is FuelEngine)
                    {
                        stringToPrint += string.Format(
                            "{0} {1}",
                            vehicle.EnergyType.ToString(),
                            Environment.NewLine);
                    }

                    if (vehicle.EnergyType is ElectricEngine)
                    {
                        stringToPrint += string.Format(
                            "{0} {1}",
                            vehicle.EnergyType.ToString(),
                            Environment.NewLine);
                    }
                }

                Console.WriteLine(stringToPrint);
            }
            else
            {
                Console.WriteLine(
                    "There are no vehicle, please add some.{0}",
                    Environment.NewLine);
            }
        }

        internal static void StatusChanged()
        {
            Console.WriteLine("The status was changed.");
        }

        public static void setVolumeOfCargo()
        {
            Console.WriteLine("Please type the volume of cargo");
        }

        public static void SetIsCooledType()
        {
            Console.WriteLine("Please choose a number for the cooled type options");
        }

        public static void SetDoorsType()
        {
            Console.WriteLine("Please choose a number for the door options");
        }

        internal static void wheelsSetToMax()
        {
            Console.WriteLine("Wheels have been inflate to max");
        }

        public static void SetColorType()
        {
            Console.WriteLine("Please choose a number for the color type options");
        }

        public static void SetVolumeEngine()
        {
            Console.WriteLine("Please insert the volume engine");
        }

        public static void SetLicenseType()
        {
            Console.WriteLine("Please choose a number for the license type options");
        }

        public static void setWheelManifactures()
        {
            Console.WriteLine("Please type the wheels manifacture name");
        }

        internal static void vehicleWasRefilled(string i_LicenseNumber, AggregateEnumTypes.eTypeOfFuel i_eTypeOfFuel, float i_AmountToRefill)
        {
            Console.WriteLine(
                "The vehicle with license: {0} was refilled by {2} of {1}",
                i_LicenseNumber,
                i_eTypeOfFuel,
                i_AmountToRefill);
        }
    }
}