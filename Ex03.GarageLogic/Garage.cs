using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, Vehicle> m_GarageVehicles;
        private string m_garageName;

        public Dictionary<string, Vehicle> GarageVehicles { get => m_GarageVehicles; set => m_GarageVehicles = value; }

        public string GarageName { get => m_garageName; set => m_garageName = value; }

        public Garage()
        {
            m_GarageVehicles = new Dictionary<string, Vehicle>();
            GarageName = this.GarageName;
        }

        public void addVehiclesToGarage(AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles, string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            Vehicle vehicleToAdd = createVehicle(eTypeOfVehicles, i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
            if (m_GarageVehicles.ContainsKey(i_LicenseNumber))
            {
                vehicleToAdd.EStatus = AggregateEnumTypes.eStatus.InRepair;
                AggregateConsoleMessages.vehicleIsAlreadyInTheGarage(vehicleToAdd);
            }
            else
            {
                GarageVehicles.Add(i_LicenseNumber, vehicleToAdd);
            }
        }

        public Dictionary<string, Vehicle> dictionaryOfVehiclesInGarageBasedOnStatus(AggregateEnumTypes.eStatus i_eStatus)
        {
            Dictionary<string, Vehicle> vehiclesInGarage = new Dictionary<string, Vehicle>();
            foreach (Vehicle vehicle in GarageVehicles.Values)
            {
                if (i_eStatus == vehicle.EStatus)
                {
                    vehiclesInGarage.Add(vehicle.LicenseNumber, vehicle);
                }
            }

            return vehiclesInGarage;
        }

        public void changeStatus(string i_LicenseNumber, AggregateEnumTypes.eStatus i_eStatus)
        {
            if (GarageVehicles.Count > 0)
            {
                foreach (string licenceNumber in GarageVehicles.Keys)
                {
                    if (licenceNumber.Equals(i_LicenseNumber))
                    {
                        GarageVehicles[i_LicenseNumber].EStatus = i_eStatus;
                        AggregateConsoleMessages.StatusChanged();
                        break;
                    }
                    else
                    {
                        AggregateConsoleMessages.licenseIsNotInTheGarage();
                    }
                }
            }
            else
            {
                AggregateConsoleMessages.vehicleIsNotInTheGarage();
            }
        }

        public void inflateWheels(string i_LicenseNumber)
        {
            foreach (string licenceNumber in m_GarageVehicles.Keys)
            {
                if (licenceNumber.Equals(i_LicenseNumber))
                {
                    if (m_GarageVehicles[i_LicenseNumber].Wheels.Length > 0)
                    {
                        m_GarageVehicles[i_LicenseNumber].setWheels(m_GarageVehicles[i_LicenseNumber].Wheels[0].MaxAirPressureRecommended);
                        AggregateConsoleMessages.wheelsSetToMax();
                    }
                    else
                    {
                        AggregateConsoleMessages.vehicleHasNoWheels();
                    }
                }
                else
                {
                    AggregateConsoleMessages.vehicleIsNotInTheGarage();
                }
            }
        }

        public void refillVehicle(string i_LicenseNumber, float i_AmountToRefill)
        {
            refillVehicle(i_LicenseNumber, 0, i_AmountToRefill);
        }

        public void refillVehicle(string i_LicenseNumber, AggregateEnumTypes.eTypeOfFuel i_eTypeOfFuel, float i_AmountToRefill)
        {
            foreach (string licenceNumber in m_GarageVehicles.Keys)
            {
                if (licenceNumber.Equals(i_LicenseNumber))
                {
                    if (m_GarageVehicles[i_LicenseNumber].EnergyType is FuelEngine)
                    {
                        if ((m_GarageVehicles[i_LicenseNumber].EnergyType as FuelEngine).TypeOfFuel.Equals(i_eTypeOfFuel))
                        {
                            (m_GarageVehicles[i_LicenseNumber].EnergyType as FuelEngine).Refuel(i_AmountToRefill);
                            AggregateConsoleMessages.vehicleWasRefilled(i_LicenseNumber, i_eTypeOfFuel, i_AmountToRefill);
                            break;
                        }
                        else
                        {
                            AggregateConsoleMessages.wrongFuel(i_LicenseNumber);
                        }
                    }
                    else if (m_GarageVehicles[i_LicenseNumber].EnergyType is ElectricEngine)
                    {
                        (m_GarageVehicles[i_LicenseNumber].EnergyType as ElectricEngine).Recharge(i_AmountToRefill);
                    }
                    else
                    {
                        AggregateConsoleMessages.theEngineOfTheVehicleisNotFillable(i_LicenseNumber);
                    }
                }
                else
                {
                    AggregateConsoleMessages.vehicleIsNotInTheGarage();
                }
            }
        }

        public void setParameterOfType<T>(string eTypeOfAggregateEnum, string i_LicenseNumber)
        {
            Vehicle vehicleToBeSet = null;
            foreach (Vehicle vehicle in GarageVehicles.Values)
            {
                if (i_LicenseNumber.Equals(vehicle.LicenseNumber))
                {
                    vehicleToBeSet = vehicle;
                }
            }

            if(vehicleToBeSet.ManifactureWheels.Equals(string.Empty))
            {
                vehicleToBeSet.ManifactureWheels = eTypeOfAggregateEnum;
            }
        }

        public void setParameterOfType<T>(int eTypeOfAggregateEnum, string i_LicenseNumber, AggregateEnumTypes.eTypeOfVehicles i_TypeOfVehicle)
        {
            Vehicle vehicleToBeSet = null;
            foreach (Vehicle vehicle in GarageVehicles.Values)
            {
                if (i_LicenseNumber.Equals(vehicle.LicenseNumber))
                {
                    vehicleToBeSet = vehicle;
                }
            }

            switch (i_TypeOfVehicle)
            {
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedMotorcycle:
                    if (typeof(T) == typeof(AggregateEnumTypes.eTypeOfLicences))
                    {
                        (vehicleToBeSet as FuelBasedMotorcycle).TypeOfLicenses = (AggregateEnumTypes.eTypeOfLicences)eTypeOfAggregateEnum;
                    }

                    if (typeof(T) == typeof(int))
                    {
                        (vehicleToBeSet as FuelBasedMotorcycle).EngineVolume = eTypeOfAggregateEnum;
                    }

                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricMotorcycle:
                    if (typeof(T) == typeof(AggregateEnumTypes.eTypeOfLicences))
                    {
                        (vehicleToBeSet as ElectricMotorcycle).TypeOfLicenses = (AggregateEnumTypes.eTypeOfLicences)eTypeOfAggregateEnum;
                    }

                    if (typeof(T) == typeof(int))
                    {
                        (vehicleToBeSet as ElectricMotorcycle).EngineVolume = eTypeOfAggregateEnum;
                    }

                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedCar:
                    if (typeof(T) == typeof(AggregateEnumTypes.eTypeColor))
                    {
                        (vehicleToBeSet as FuelBasedCar).TypeOfColor = (AggregateEnumTypes.eTypeColor)eTypeOfAggregateEnum;
                    }

                    if (typeof(T) == typeof(AggregateEnumTypes.eNumOfDoors))
                    {
                        (vehicleToBeSet as FuelBasedCar).NumOfDoors = (AggregateEnumTypes.eNumOfDoors)eTypeOfAggregateEnum;
                    }

                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricCar:
                    if (typeof(T) == typeof(AggregateEnumTypes.eTypeColor))
                    {
                        (vehicleToBeSet as ElectricCar).TypeOfColor = (AggregateEnumTypes.eTypeColor)eTypeOfAggregateEnum;
                    }

                    if (typeof(T) == typeof(AggregateEnumTypes.eNumOfDoors))
                    {
                        (vehicleToBeSet as ElectricCar).NumOfDoors = (AggregateEnumTypes.eNumOfDoors)eTypeOfAggregateEnum;
                    }

                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedTruck:
                    if (typeof(T) == typeof(AggregateEnumTypes.eIsCooled))
                    {
                        (vehicleToBeSet as FuelBasedTruck).IsCooled = (AggregateEnumTypes.eIsCooled)eTypeOfAggregateEnum;
                    }

                    if (typeof(T) == typeof(float))
                    {
                        (vehicleToBeSet as FuelBasedTruck).VolumeOfCargo = float.Parse(eTypeOfAggregateEnum.ToString());
                    }

                    break;
                default:
                    vehicleToBeSet = null;
                    break;
            }
        }

        private Vehicle createVehicle(AggregateEnumTypes.eTypeOfVehicles eTypeOfVehicles, string i_ModelName, string i_LicenseNumber, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            Vehicle vehicle;
            switch (eTypeOfVehicles)
            {
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedMotorcycle:
                    vehicle = new FuelBasedMotorcycle(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricMotorcycle:
                    vehicle = new ElectricMotorcycle(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedCar:
                    vehicle = new FuelBasedCar(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.ElectricCar:
                    vehicle = new ElectricCar(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                case AggregateEnumTypes.eTypeOfVehicles.FuelBasedTruck:
                    vehicle = new FuelBasedTruck(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber);
                    break;
                default:
                    vehicle = null;
                    break;
            }

            return vehicle;
        }

        public void displayDictionary()
        {
            AggregateConsoleMessages.displayDictionary(m_GarageVehicles);
        }

        public void displayVehiclesInformation()
        {
            AggregateConsoleMessages.displayVehicle(m_GarageVehicles);
        }
    }
}
